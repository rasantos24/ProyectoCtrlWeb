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
    
    public partial class glCuentasGrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public glCuentasGrupo()
        {
            this.glCuentas = new HashSet<glCuenta>();
            this.glCuentasSubGrupoes = new HashSet<glCuentasSubGrupo>();
        }
    
        public string IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glCuenta> glCuentas { get; set; }
        public virtual glCuentasCategoria glCuentasCategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glCuentasSubGrupo> glCuentasSubGrupoes { get; set; }
    }
}
