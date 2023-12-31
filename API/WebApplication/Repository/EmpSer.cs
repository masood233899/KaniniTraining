﻿using Microsoft.EntityFrameworkCore;
using CdefrstEfApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CdefrstEfApi.Repository
{
    public class EmpSer : IEmprepo
    {
        private readonly CfApiContxt _cfApiContxt;

        public EmpSer(CfApiContxt cfApiContxt)
        {
            _cfApiContxt = cfApiContxt;
        }
        public async Task<List<Emp?>> GetEmps()
        {
            var emp = await _cfApiContxt.Emps.ToListAsync();
            return emp;
        }
        public async Task<Emp?> GetEmp(int id)
        {
            var empn = await _cfApiContxt.Emps.FirstOrDefaultAsync(e => e.Empid == id);
            if (empn == null)
            {
                return null;
            }
            return empn;
        }
        public async Task<Emp> PutEmp(int id, Emp emp)
        {
            var empn = await _cfApiContxt.Emps.FirstOrDefaultAsync(e => e.Empid == id);
            if (empn == null)
            {
                return null;
            }
            empn.Empid = emp.Empid;
            empn.Empname = emp.Empname;
            empn.Deptid = emp.Deptid;

            await _cfApiContxt.SaveChangesAsync();

            return empn;

        }
        public async Task<Emp> PostEmp(Emp emps)
        {
            _cfApiContxt.Add(emps);
            await _cfApiContxt.SaveChangesAsync();
            return emps;
        }
        public async Task<string> DeleteEmp(int id)
        {
            var empn = await _cfApiContxt.Emps.FirstOrDefaultAsync(e => e.Empid == id);
            _cfApiContxt.Remove(empn);
            await _cfApiContxt.SaveChangesAsync();
            return "Deleted done";

        }

    }
}
