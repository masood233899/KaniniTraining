using Microsoft.EntityFrameworkCore;
using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CdefrstEfApi.Repository
{
    public class DeptSer : IRepository
    {
        public CfApiContxt _cfApiContxt;
        public DeptSer(CfApiContxt cfApiContxt)
        {
            _cfApiContxt = cfApiContxt;
        }
        public async Task<ActionResult<IEnumerable<Dept>>> GetDepts()
        {
            var stds = await _cfApiContxt.Depts.ToListAsync();
            return stds;
        }
        public async Task<Dept?> GetDept(int id)
        {
            var deptno = await _cfApiContxt.Depts.FirstOrDefaultAsync(x => x.Deptid == id);
            if (deptno == null)
            {
                return null;
            }
            return deptno;
        }
        public async Task<Dept> PutDept(int id, Dept dept)
        {
            var deptidpt = await _cfApiContxt.Depts.FirstOrDefaultAsync(x => x.Deptid == id);
            if (deptidpt == null)
            {
                return null;
            }

            deptidpt.Deptid = dept.Deptid;
            deptidpt.Deptname = dept.Deptname;

            await _cfApiContxt.SaveChangesAsync();

            return dept;
        }
        public async Task<Dept> PostDept(Dept dept)
        {
            _cfApiContxt.Add(dept);
            _cfApiContxt.SaveChanges();
            return dept;

        }
        public async Task<string> DeleteDept(int id)
        {
            var deldeptidpt = await _cfApiContxt.Depts.FirstOrDefaultAsync(x => x.Deptid == id);
            _cfApiContxt.Remove(deldeptidpt);
            _cfApiContxt.SaveChanges(true);

            return "Deleted";

        }
    }
}
