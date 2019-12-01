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
    
    public partial class gcPrestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gcPrestamo()
        {
            this.gcOrdenPagoes = new HashSet<gcOrdenPago>();
            this.gcPrestamosAmors = new HashSet<gcPrestamosAmor>();
            this.gcPrestamosAmorMovs = new HashSet<gcPrestamosAmorMov>();
            this.gcPrestamosAmorMovDets = new HashSet<gcPrestamosAmorMovDet>();
            this.gcPrestamosAvales = new HashSet<gcPrestamosAvale>();
            this.gcPrestamosDocs = new HashSet<gcPrestamosDoc>();
            this.gcPrestamosGars = new HashSet<gcPrestamosGar>();
            this.gcPrestamosRefComs = new HashSet<gcPrestamosRefCom>();
            this.gcPrestamosRefFins = new HashSet<gcPrestamosRefFin>();
            this.gcPrestamosRefPers = new HashSet<gcPrestamosRefPer>();
            this.gcPrestamosReqs = new HashSet<gcPrestamosReq>();
        }
    
        public int NoPrestamo { get; set; }
        public string IdTipoPrestamo { get; set; }
        public string IdCliente { get; set; }
        public string Cliente { get; set; }
        public string TipoCalculo { get; set; }
        public bool CalcularMora { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaOtorgado { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> TasaIntAnual { get; set; }
        public Nullable<decimal> TasaIntMensual { get; set; }
        public Nullable<decimal> IntMoraAnual { get; set; }
        public Nullable<decimal> IntMoraMensual { get; set; }
        public Nullable<decimal> PlazoAnios { get; set; }
        public Nullable<decimal> PlazoMeses { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Intereses { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string IdUsuarioCreado { get; set; }
        public string IdUsuarioProceso { get; set; }
        public string Referencia { get; set; }
        public string Notas { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public string cStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcOrdenPago> gcOrdenPagoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosAmor> gcPrestamosAmors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosAmorMov> gcPrestamosAmorMovs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosAmorMovDet> gcPrestamosAmorMovDets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosAvale> gcPrestamosAvales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosDoc> gcPrestamosDocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosGar> gcPrestamosGars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosRefCom> gcPrestamosRefComs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosRefFin> gcPrestamosRefFins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosRefPer> gcPrestamosRefPers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gcPrestamosReq> gcPrestamosReqs { get; set; }
    }
}
