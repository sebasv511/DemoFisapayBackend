using DemoFisapayBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoFisapayBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EmpleadoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listEmpleados = await _context.empleado.ToListAsync();
                return Ok(listEmpleados);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empleado empleado)
        {
            try
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return Ok(empleado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Empleado empleado)
        {
            try
            {
                if (id != empleado.Id)
                {
                    return NotFound();
                }

                _context.Update(empleado);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Empleado actualizado exitosamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var empleado = await _context.empleado.FindAsync(id);
                if (empleado == null)
                {
                    return NotFound();
                }

                _context.empleado.Remove(empleado);
                await _context.SaveChangesAsync();
                return Ok(new { messge = "Empleado eliminado exitosamente"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
