using PetsLocalizer2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Repositorio
{
    public class MascotasRepository : BaseRepository<Mascotas>
    {
        public List<Mascotas> GetMascotasPropietario(string cedula)
        {
            return _set.Where(p => p.Propietario.Cedula == cedula).ToList();
        }
        public List<Mascotas> GetPerritosMayores2Y()
        {
            return _set.Where(p => p.Edad >= 2 && p.TipoEdad == "año").ToList();
        }
    }
}
