using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Entities
{
    public class Ubicaciones
    {
        [Key]
        public int Id { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int MascotaId { get; set; }
        public virtual Mascotas Mascotas { get; set; }
    }
}
