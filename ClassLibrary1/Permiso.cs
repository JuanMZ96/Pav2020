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
    
    public partial class Permiso
    {
        public int id_formulario { get; set; }
        public int id_perfil { get; set; }
        public Nullable<int> borrado { get; set; }
    
        public virtual Formulario Formulario { get; set; }
        public virtual Perfile Perfile { get; set; }
    }
}
