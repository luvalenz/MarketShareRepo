﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketShare.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //propiedad de navegación
        public virtual ICollection<Producto> Productos { get; set; }
    }
}