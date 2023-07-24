using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CdefrstEfApi.Models;
using CdefrstEfApi.Repository;

namespace CdefrstEfApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpDetailsController : ControllerBase
    {
        private readonly IEmpdet _context;

        public EmpDetailsController(IEmpdet context)
        {
            _context = context;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<List<EmpDetails>> GetEmpDetails()
        {
            return await _context.GetEmpDetails();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpDetails?>> GetEmpDetails(int id)

        {

            var emp = await _context.GetEmpDetails(id);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }

        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<List<EmpDetails>>> PutEmpDetails(int id, EmpDetails empDetails)
        {
            var emp = await _context.PutEmpDetails(id, empDetails);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }

        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpDetails>> PostEmpDetails(EmpDetails empDetails)
        {
            var emp = await _context.PostEmpDetails(empDetails);

            if (emp == null)
            {
                return NotFound("not matching");
            }

            return Ok(emp);
        }

        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpDetails>> DeleteEmpDetails(int id)
        {
            var emp = await _context.DeleteEmpDetails(id);

            if (emp == null)
            {
                return NotFound("not matching");
            }
            return Ok(emp);
        }
    }
}
