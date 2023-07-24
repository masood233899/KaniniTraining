using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace CdefrstEfApi.Repository
{
    public interface IEmpdet
    {
        Task<List<EmpDetails>> GetEmpDetails();
        Task<EmpDetails?> GetEmpDetails(int id);
        Task<EmpDetails> PutEmpDetails(int id, EmpDetails empDetails);
        Task<EmpDetails> PostEmpDetails(EmpDetails empDetails);
        Task<string> DeleteEmpDetails(int id);
    }
}
