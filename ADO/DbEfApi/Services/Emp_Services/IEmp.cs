using DbEfApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbEfApi.Services.Emp_Services
{
    public interface IEmp
    {
        Task<List<Emp>> GetEmps();
        Task<Emp?> GetEmp(int id);
        Task<Emp> PutEmp(int id, Emp emp);
        Task<Emp> PostEmp(Emp emps);
        Task<string> DeleteEmp(int id);
    }
}
