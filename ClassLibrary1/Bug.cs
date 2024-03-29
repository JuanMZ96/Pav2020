
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
    
public partial class Bug
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Bug()
    {

        this.BugsHistoricoes = new HashSet<BugsHistorico>();

    }


    public int id_bug { get; set; }

    public string titulo { get; set; }

    public string descripcion { get; set; }

    public System.DateTime fecha_alta { get; set; }

    public Nullable<int> id_usuario_responsable { get; set; }

    public Nullable<int> id_usuario_asignado { get; set; }

    public Nullable<int> id_producto { get; set; }

    public Nullable<int> id_prioridad { get; set; }

    public Nullable<int> id_criticidad { get; set; }

    public Nullable<int> id_estado { get; set; }

    public Nullable<bool> borrado { get; set; }



    public virtual Criticidade Criticidade { get; set; }

    public virtual Estado Estado { get; set; }

    public virtual Prioridade Prioridade { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Usuario Usuario { get; set; }

    public virtual Usuario Usuario1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BugsHistorico> BugsHistoricoes { get; set; }

}

}
