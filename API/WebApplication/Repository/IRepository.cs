using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CdefrstEfApi.Repository
{
    public interface IRepository
    {
        Task<ActionResult<IEnumerable<Dept>>> GetDepts();
        Task<Dept?> GetDept(int id);
        Task<Dept> PutDept(int id, Dept dept);
        Task<Dept> PostDept(Dept dept);
        Task<string> DeleteDept(int id);
        


    }
}
