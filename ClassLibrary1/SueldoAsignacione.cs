//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class SueldoAsignacione
    {
        public int id_usuario { get; set; }
        public System.DateTime fecha { get; set; }
        public int id_asignacion { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<int> cantidad { get; set; }
    
        public virtual Asignacione Asignacione { get; set; }
        public virtual Sueldo Sueldo { get; set; }
    }
}