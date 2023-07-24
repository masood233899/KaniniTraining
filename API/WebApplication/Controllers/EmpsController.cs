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
    public class EmpsController : ControllerBase
    {
        private readonly IEmprepo _repository;

        public EmpsController(IEmprepo repository)
        {
            _repository = repository;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<List<Emp>> GetEmps()
        {
            return await _repository.GetEmps();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp?>> GetEmp(int id)

        {

            var emp = await _repository.GetEmp(id);

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
            var emp = await _repository.PutEmp(id, emps);

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
            var emp = await _repository.PostEmp(emps);

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
            var emp = await _repository.DeleteEmp(id);

            if (emp == null)
            {
                return NotFound("not matching");
            }
            return Ok(emp);
        }
    }
}
