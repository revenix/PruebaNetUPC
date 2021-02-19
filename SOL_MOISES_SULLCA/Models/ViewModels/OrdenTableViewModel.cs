using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_MOISES_SULLCA.Models.ViewModels
{
    public class OrdenTableViewModel
    {

        public string cliente { get; set; }

        public string Producto { get; set; }
        public int cantidad { get; set; }
        public decimal importe_unitario { get; set; }

        public decimal importe_total { get; set; }
     


        public decimal precio_unitario { get; set; }

        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_estimada { get; set; }

    }
}