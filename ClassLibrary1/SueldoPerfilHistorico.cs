
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
    
public partial class SueldoPerfilHistorico
{

    public int id_perfil { get; set; }

    public System.DateTime fecha { get; set; }

    public decimal sueldo { get; set; }



    public virtual Perfile Perfile { get; set; }

}

}
