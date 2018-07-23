using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thlem.Models;
using thlem.Data;
using thlem.Data.Eintities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace thlem.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        private readonly IThlemRepoistory _repoistory;
        private readonly IMapper _mapper;

        public HomeController(IThlemRepoistory repoistory, IMapper mapper)
        {
            _repoistory = repoistory;
            _mapper = mapper;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //here Register Company Controller
        public IActionResult RegisterCompany()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterCompany(RegisterCompany company, IFormFile file)
        {
            if (file != null)
            {
                company.Image = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Img/", company.Image);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            _repoistory.AddCompany(company);
            _repoistory.SaveChange();
            return RedirectToAction("CompanyRegiList");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult CompanyRegiList()
        {
            var register = _repoistory.GetAllCompanyReg();
            return View(_mapper.Map<IEnumerable<RegisterCompany>, IEnumerable<RegCompanyViewModel>>(register));
        }
        public IActionResult DeleteCompanyRegister(int id)
        {
            RegisterCompany check = _repoistory.FindCompanyReg(id);
                return View(_mapper.Map<RegisterCompany,RegCompanyViewModel>(check));
        }
        [HttpPost]
        [ActionName("DeleteCompanyRegister")]
        public IActionResult DeleteCompanyRegister2(int id)
        {
            _repoistory.DeleteCompanyRegister(id);
            _repoistory.SaveChange();
            return RedirectToAction("CompanyRegiList");
        }
        public IActionResult EditCompanyRegister(int id)
        {
            RegisterCompany check = _repoistory.FindCompanyReg(id);
            if (check != null)
            {
                return View(_mapper.Map<RegisterCompany, RegCompanyViewModel>(check));
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult EditCompanyRegister(int id, RegCompanyViewModel model )
        {
            RegisterCompany check = _repoistory.FindCompanyReg(id);

            if(check != null)
            {
                RegisterCompany mo = _mapper.Map<RegCompanyViewModel, RegisterCompany>(model);
                check.Name = mo.Name;
                check.Brief = mo.Brief;
                check.Location = mo.Location;
                _repoistory.SaveChange();
                //_repoistory.UpdateCompanyRegister(id);
                return RedirectToAction("CompanyRegiList");
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult DetailsCompanyReg(int id)
        {
            var find = _repoistory.FindCompanyReg(id);
            if (find != null)
            {
                return View(_mapper.Map<RegisterCompany, RegCompanyViewModel>(find));
            }
            return NotFound();
        }


        

        //here Submit Controller
        public IActionResult SubmitCompany()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SubmitCompany(CompanySubmition submitCompany, IFormFile file)
        { 
            if (file != null)
            {
                submitCompany.File = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Img/", submitCompany.File);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            _repoistory.AddSubmitCompany(submitCompany);
            _repoistory.SaveChange();
            return RedirectToAction("CompanySUBMITList");
        }
        public IActionResult CompanySUBMITList()
        {
            var list = _repoistory.GetAllComapnySubmition();

            return View(_mapper.Map<IEnumerable<CompanySubmition>,IEnumerable<CompanySubViewModel>>(list));
        }
        [HttpGet]
        public IActionResult DeleteCompanySubmit(int id)
        {
            CompanySubmition check = _repoistory.FindCompanySumition(id);
            return View(_mapper.Map<CompanySubmition, CompanySubViewModel>(check));
        }
        [HttpPost]
        [ActionName("DeleteCompanySubmit")]
        public IActionResult DeleteCompanySubmit2(int id)
        {
            _repoistory.DeleteSubmitCompany(id);
            _repoistory.SaveChange();
            return RedirectToAction("CompanySUBMITList");
        }


    }
}
