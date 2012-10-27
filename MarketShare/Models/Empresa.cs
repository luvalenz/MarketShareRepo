using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketShare.Models
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        //propiedad de navegación
        public virtual ICollection<Producto> Productos { get; set; }
    }
}