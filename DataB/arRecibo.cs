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
    
    public partial class arRecibo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public arRecibo()
        {
            this.arRecibosDetalles = new HashSet<arRecibosDetalle>();
            this.arRecibosMetodos = new HashSet<arRecibosMetodo>();
        }
    
        public int NoRecibo { get; set; }
        public string IdCliente { get; set; }
        public Nullable<int> NoTurno { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoAplicado { get; set; }
        public decimal MontoNoAplicado { get; set; }
        public string TipoDePago { get; set; }
        public string ModuloOrigen { get; set; }
        public string Referencia { get; set; }
        public string Notas { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public string IdUsuario { get; set; }
        public string cStatus { get; set; }
        public bool Posteado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arRecibosDetalle> arRecibosDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arRecibosMetodo> arRecibosMetodos { get; set; }
    }
}
