using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MarketShare.Models
{
    public class Produto_Tag
    {
        public int IntermediaID { get; set; }

        public int ProductoID { get; set; }        
        public int TagID { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Tag Tag { get; set; }
    }
}