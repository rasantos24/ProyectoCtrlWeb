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
    
    public partial class gcPrestamosTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gcPrestamosTipo()
        {
            this.gcPrestamosTipoDocs = new HashSet<gcPrestamosTipoDoc>();
            this.gcPrestamosTipoReqs = new HashSet<gcPrestamosTipoReq>();
        }
    
        public string IdTipoPrestamo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> TasaIntAnual { get; set; }
        public Nullable<decimal> TasaIntMensual { get; set; }
        public Nullable<decimal> IntMoraAnual { get; set; }
        public Nullable<decimal> IntMoraMensual { get; set; }
        public string TipoCalculo { get; set; }
        public Nullable<decimal> PlazoMaximoAnios { get; set; }
        public Nullable<decimal> PlazoMaximoMeses { get; set; }
        public Nullable<bool> RequiereAval { get; set; }
        public string Notas { get; set; }
        public bool lStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosTipoDoc> gcPrestamosTipoDocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosTipoReq> gcPrestamosTipoReqs { get; set; }
    }
}
