//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOL_MOISES_SULLCA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden_detalle
    {
        public int id { get; set; }
        public int id_orden { get; set; }
        public string id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal importe { get; set; }
    
        public virtual orden orden { get; set; }
        public virtual producto producto { get; set; }
    }
}
