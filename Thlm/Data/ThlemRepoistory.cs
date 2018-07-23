using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thlem.Data.Eintities;
using thlem.Models;

namespace thlem.Data
{
    public class ThlemRepoistory : IThlemRepoistory
    {
        private readonly ThlemContext _context;

        public ThlemRepoistory(ThlemContext context)
        {
            _context = context;
        }

        public void AddCompany(RegisterCompany company)
        {
            _context.RegisterCompany.Add(company);
        }
        public bool SaveChange()
        {
            return _context.SaveChanges() > 0;
        }
        public IEnumerable<RegisterCompany> GetAllCompanyReg()
        {
            return _context.RegisterCompany
                .OrderBy(p => p.Id)
                .ToList();
        }

        public void AddSubmitCompany(CompanySubmition submitCompany)
        {
            _context.CompanySubmition.Add(submitCompany);
        }
        public IEnumerable<CompanySubmition> GetAllComapnySubmition()
        {
            return _context.CompanySubmition
                .OrderBy(o => o.Id)
                .ToList();
        }
        public RegisterCompany FindCompanyReg(int id)
        {
            RegisterCompany model = _context.RegisterCompany.Where(p => p.Id == id).FirstOrDefault();
            if (model != null)
            {
                return model;
            }
            else return null;
        }
        public void DeleteCompanyRegister(int id)
        {
            var fi=FindCompanyReg(id);
            _context.RegisterCompany.Remove(fi);
           
        }
        public CompanySubmition FindCompanySumition(int id)
        {
            var model = _context.CompanySubmition.Where(p => p.Id == id).FirstOrDefault();
            if (model != null)
            {
                return model;
            }
            else return null;

        }
        public void UpdateCompanyRegister(int id)
        {
            var Model = FindCompanyReg(id);
            var x = _context.RegisterCompany.Update(Model);
           
        }
        public void DeleteSubmitCompany(int id)
        {
            var fi = FindCompanySumition(id);
            _context.CompanySubmition.Remove(fi);
        }






    }
}
