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
    
    public partial class gcPrestamosDoc
    {
        public int NuId { get; set; }
        public Nullable<int> NoPrestamo { get; set; }
        public string IdTipoDocumento { get; set; }
        public string RutaArchivo { get; set; }
        public bool Requerido { get; set; }
        public string Notas { get; set; }
    
        public virtual gcPrestamo gcPrestamo { get; set; }
    }
}
