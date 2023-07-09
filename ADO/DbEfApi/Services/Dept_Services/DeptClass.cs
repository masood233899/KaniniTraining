using DbEfApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DbEfApi.Services;
using Microsoft.VisualBasic;

namespace DbEfApi.Services.Dept_Services
{
    public class DeptClass : IDept
    {
        private DbconApiContext _dbconApiContext;

        public DeptClass(DbconApiContext dbconApiContext)
        {
            _dbconApiContext = dbconApiContext;
        }
        public async Task<List<Dept?>> GetDepts()
        {
            var dept = await _dbconApiContext.Depts.ToListAsync();
            return dept;
        }

        public async Task<Dept?> GetDept(int id)
        {
            var deptno = await _dbconApiContext.Depts.FirstOrDefaultAsync(x=>x.Deptno==id);
            if (deptno == null)
            {
                return null;
            }
            return deptno;
        }

        public async Task<Dept> PutDept(int id, Dept dept)
        {
            var deptidpt =  await _dbconApiContext.Depts.FirstOrDefaultAsync(x => x.Deptno == id);
            if(deptidpt == null)
            {
                return null;
            }

            deptidpt.Deptno = dept.Deptno;
            deptidpt.Ename = dept.Ename;

            await _dbconApiContext.SaveChangesAsync();

            return dept;
        }

        public async Task<Dept> PostDept(Dept dept)
        {
            _dbconApiContext.Add(dept);
            _dbconApiContext.SaveChanges();
            return dept;

        }
        public async Task<string> DeleteDept(int id)
        {
            var deldeptidpt = await _dbconApiContext.Depts.FirstOrDefaultAsync(x => x.Deptno == id);
            _dbconApiContext.Remove(deldeptidpt);
            _dbconApiContext.SaveChanges(true);

            return "Deleted";
            
        }



    }

}
