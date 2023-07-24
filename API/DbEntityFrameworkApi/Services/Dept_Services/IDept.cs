using DbEfApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbEfApi.Services.Dept_Services
{
    public interface IDept
    {
        Task<List<Dept?>> GetDepts();
        Task<Dept?> GetDept(int id);
        Task<Dept> PutDept(int id, Dept dept);
        Task<Dept> PostDept(Dept dept);
        Task<string> DeleteDept(int id);
    }
}
