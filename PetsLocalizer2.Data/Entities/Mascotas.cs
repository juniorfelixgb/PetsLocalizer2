using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Entities
{
    public class Mascotas
    {
        [Key]
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public double Edad { get; set; }

        public string TipoEdad { get; set; }

        public string Direccion { get; set; }

        public virtual ICollection<Ubicaciones> Ubicaciones { get; set; }

        public virtual Propietario Propietario { get; set; }
    }
}
