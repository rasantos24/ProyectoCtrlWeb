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
    
    public partial class bnMoneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bnMoneda()
        {
            this.apProveedores = new HashSet<apProveedore>();
            this.bnBancos = new HashSet<bnBanco>();
            this.icRecepciones = new HashSet<icRecepcione>();
        }
    
        public string IdMoneda { get; set; }
        public string Descripcion { get; set; }
        public string Simbolo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedore> apProveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bnBanco> bnBancos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRecepcione> icRecepciones { get; set; }
    }
}