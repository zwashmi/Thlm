using System.Collections.Generic;
using thlem.Data.Eintities;

namespace thlem.Data
{
    public interface IThlemRepoistory
    {
        void AddCompany(RegisterCompany company);
        bool SaveChange();
        IEnumerable<RegisterCompany> GetAllCompanyReg();
        void AddSubmitCompany(CompanySubmition submitCompany);
        IEnumerable<CompanySubmition> GetAllComapnySubmition();
        RegisterCompany FindCompanyReg(int id);
        void DeleteCompanyRegister(int id);
        CompanySubmition FindCompanySumition(int id);
        void UpdateCompanyRegister(int id);
        void DeleteSubmitCompany(int id);


    }
}