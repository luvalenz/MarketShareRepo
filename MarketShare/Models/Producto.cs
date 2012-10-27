using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MarketShare.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }        
        public string Nombre { get; set; }

        //clave foranea
        public int EmpresaID { get; set; }
        //propiedad de navegacion
        public virtual Empresa Empresa { get; set; }

        //clave foranea
        public int CategoriaID { get; set; }
        //propiedad de navegacion
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public string PathImagen { get; set; }

    }
}