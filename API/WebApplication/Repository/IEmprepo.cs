using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace CdefrstEfApi.Repository
{
    public interface IEmprepo
    {
        Task<List<Emp>> GetEmps();
        Task<Emp?> GetEmp(int id);
        Task<Emp> PutEmp(int id, Emp emp);
        Task<Emp> PostEmp(Emp emps);
        Task<string> DeleteEmp(int id);
    }
}
