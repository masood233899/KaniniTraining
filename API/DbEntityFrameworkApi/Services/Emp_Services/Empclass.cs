using DbEfApi.Models;
using Microsoft.EntityFrameworkCore;
using DbEfApi.Services;
using DbEfApi.Controllers;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

namespace DbEfApi.Services.Emp_Services
{
    public class Empclass : IEmp
    {
        private readonly DbconApiContext _dbconApiContext;

        public Empclass(DbconApiContext dbconApiContext)
        {
            _dbconApiContext = dbconApiContext;
        }
        public async Task<List<Emp?>> GetEmps()
        {
            var emp = await _dbconApiContext.Emps.ToListAsync();
            return emp;
        }
        public async Task<Emp?> GetEmp(int id)
        {
            var empn = await _dbconApiContext.Emps.FirstOrDefaultAsync(e => e.Empno == id);
            if(empn == null)
            {
                return null;
            }
            return empn;
        }
        public async Task<Emp> PutEmp(int id, Emp emp)
        {
            var empn = await _dbconApiContext.Emps.FirstOrDefaultAsync(e => e.Empno == id);
            if (empn == null)
            {
                return null;
            }
            empn.Empno = emp.Empno;
            empn.Ename = emp.Ename;
            empn.Deptno = emp.Deptno;

            await _dbconApiContext.SaveChangesAsync();

            return empn;

        }
        public async Task<Emp> PostEmp(Emp emps)
        {
            _dbconApiContext.Add(emps);
            await _dbconApiContext.SaveChangesAsync();
            return emps;
        }
        public async Task<string> DeleteEmp(int id)
        {
            var empn = await _dbconApiContext.Emps.FirstOrDefaultAsync(e => e.Empno == id);
            _dbconApiContext.Remove(empn);
            await _dbconApiContext.SaveChangesAsync();
            return "Deleted done";
            
        }


    }
}
