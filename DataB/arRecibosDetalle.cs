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
    
    public partial class arRecibosDetalle
    {
        public int NuId { get; set; }
        public int NoRecibo { get; set; }
        public string TipoDocumento { get; set; }
        public int NoDocumento { get; set; }
        public Nullable<int> NoCuota { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal SaldoPrevio { get; set; }
        public decimal Saldo { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public string IdUsuario { get; set; }
    
        public virtual arRecibo arRecibo { get; set; }
    }
}
