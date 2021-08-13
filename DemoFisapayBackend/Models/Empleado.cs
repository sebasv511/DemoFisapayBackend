using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFisapayBackend.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public decimal Salario { get; set; }
        [Required]
        public string  VacunaCovid { get; set; }
    }
}
