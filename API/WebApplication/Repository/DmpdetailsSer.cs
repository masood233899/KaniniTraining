using Microsoft.EntityFrameworkCore;
using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace CdefrstEfApi.Repository
{
    public class DmpdetailsSer : IEmpdet
    {
        private readonly CfApiContxt _cfApiContxt;

        public DmpdetailsSer(CfApiContxt cfApiContxt)
        {
            _cfApiContxt = cfApiContxt;
        }
        public async Task<List<EmpDetails?>> GetEmpDetails()
        {
            var emp = await _cfApiContxt.EmpDetails.ToListAsync();
            return emp;
        }
        public async Task<EmpDetails?> GetEmpDetails(int id)
        {
            var empn = await _cfApiContxt.EmpDetails.FirstOrDefaultAsync(e => e.empno == id);
            if (empn == null)
            {
                return null;
            }
            return empn;
        }
        public async Task<EmpDetails> PutEmpDetails(int id, EmpDetails empDetails)
        {
            var empn = await _cfApiContxt.EmpDetails.FirstOrDefaultAsync(e => e.empno == id);
            if (empn == null)
            {
                return null;
            }
            empn.empno = empDetails.empno;
            empn.panno = empDetails.panno;
            empn.aadharno = empDetails.aadharno;

            await _cfApiContxt.SaveChangesAsync();

            return empn;

        }
        public async Task<EmpDetails> PostEmpDetails(EmpDetails empDetails)
        {
            _cfApiContxt.Add(empDetails);
            await _cfApiContxt.SaveChangesAsync();
            return empDetails;
        }
        public async Task<string> DeleteEmpDetails(int id)
        {
            var empn = await _cfApiContxt.EmpDetails.FirstOrDefaultAsync(e => e.empno == id);
            _cfApiContxt.Remove(empn);
            await _cfApiContxt.SaveChangesAsync();
            return "Deleted done";

        }
    }
}
