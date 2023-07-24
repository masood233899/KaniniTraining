using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DbEfApi.Models;
using DbEfApi.Services.Emp_Services;

namespace DbEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly IEmp _context;

        public EmpsController(IEmp context)
        {
            _context = context;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task< List<Emp?>> GetEmps()
        {
            return await _context.GetEmps();
        }
        
        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp?>> GetEmp(int id)

        {

            var emp = await _context.GetEmp(id);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }
        
        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Emp>>> PutEmp(int id, Emp emps)
        {
            var emp = await _context.PutEmp(id,emps);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }
        
        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emp>> PostEmp(Emp emps)
        {
            var emp = await _context.PostEmp(emps);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }
        
        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Emp>> DeleteEmp(int id)
        {
            var emp = await _context.DeleteEmp(id);

            if (emp == null)
            {
                return NotFound("not matching");
            }
            return Ok(emp);
        }

       
    }
}
