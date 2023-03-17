using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Patern.Entity
{
   public class Product:Ientity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
