using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Entities
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public ICollection<Mascotas> Mascotas { get; set; }
    }
}
