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
    
    public partial class SysRutaProceso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysRutaProceso()
        {
            this.SysRutaProcesosDets = new HashSet<SysRutaProcesosDet>();
        }
    
        public string IdRuta { get; set; }
        public string Descripcion { get; set; }
        public string IdModulo { get; set; }
        public string IdForm { get; set; }
        public string Metodo { get; set; }
        public bool lStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysRutaProcesosDet> SysRutaProcesosDets { get; set; }
    }
}
