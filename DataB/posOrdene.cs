//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CtrlWebT.DataB
{
    using System;
    using System.Collections.Generic;
    
    public partial class posOrdene
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public posOrdene()
        {
            this.posOrdenesDetalles = new HashSet<posOrdenesDetalle>();
        }
    
        public int NoOrden { get; set; }
        public string NoFactura { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Descuentos { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string IdUsuario { get; set; }
        public string cStatus { get; set; }
        public string Notas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<posOrdenesDetalle> posOrdenesDetalles { get; set; }
    }
}