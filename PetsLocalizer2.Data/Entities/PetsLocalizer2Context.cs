using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Entities
{
    public class PetsLocalizer2Context : DbContext
    {
        public PetsLocalizer2Context() :
            base("name=PetsLocalizer2Context")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
