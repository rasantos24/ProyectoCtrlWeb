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
    
    public partial class glCuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public glCuenta()
        {
            this.apProveedores = new HashSet<apProveedore>();
            this.apProveedoresTipoes = new HashSet<apProveedoresTipo>();
            this.apProveedoresTipoes1 = new HashSet<apProveedoresTipo>();
            this.apProveedoresTipoes2 = new HashSet<apProveedoresTipo>();
            this.arClientes = new HashSet<arCliente>();
            this.arClientesTipoes = new HashSet<arClientesTipo>();
            this.arDescuentos = new HashSet<arDescuento>();
            this.arMetodoPagoes = new HashSet<arMetodoPago>();
            this.arNotaCreditoTipoes = new HashSet<arNotaCreditoTipo>();
            this.arNotaDebitoTipoes = new HashSet<arNotaDebitoTipo>();
            this.bnBancos = new HashSet<bnBanco>();
            this.SysTaxes = new HashSet<SysTax>();
            this.SysTaxes1 = new HashSet<SysTax>();
            this.icAjusteClases = new HashSet<icAjusteClase>();
            this.icAlmacenes = new HashSet<icAlmacene>();
            this.icTipoInventarioCtasCostos = new HashSet<icTipoInventarioCtasCosto>();
            this.icTipoInventarioCtasIngresos = new HashSet<icTipoInventarioCtasIngreso>();
            this.icDeptos = new HashSet<icDepto>();
            this.icDeptos1 = new HashSet<icDepto>();
        }
    
        public string IdCuenta { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public string Tipo { get; set; }
        public string CreditoDebito { get; set; }
        public string IdGrupo { get; set; }
        public string IdSubGrupo { get; set; }
        public string IdDepto { get; set; }
        public bool Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedore> apProveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedoresTipo> apProveedoresTipoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedoresTipo> apProveedoresTipoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedoresTipo> apProveedoresTipoes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arCliente> arClientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arClientesTipo> arClientesTipoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arDescuento> arDescuentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arMetodoPago> arMetodoPagoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arNotaCreditoTipo> arNotaCreditoTipoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arNotaDebitoTipo> arNotaDebitoTipoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bnBanco> bnBancos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysTax> SysTaxes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysTax> SysTaxes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icAjusteClase> icAjusteClases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icAlmacene> icAlmacenes { get; set; }
        public virtual glCuentasCategoria glCuentasCategoria { get; set; }
        public virtual glCuentasGrupo glCuentasGrupo { get; set; }
        public virtual glCuentasSubGrupo glCuentasSubGrupo { get; set; }
        public virtual icDepto icDepto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icTipoInventarioCtasCosto> icTipoInventarioCtasCostos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icTipoInventarioCtasIngreso> icTipoInventarioCtasIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icDepto> icDeptos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icDepto> icDeptos1 { get; set; }
    }
}
