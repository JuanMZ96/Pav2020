
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
    
public partial class Proyecto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Proyecto()
    {

        this.FacturasDetalles = new HashSet<FacturasDetalle>();

        this.PlanesDePruebas = new HashSet<PlanesDePrueba>();

    }


    public int id_proyecto { get; set; }

    public Nullable<int> id_producto { get; set; }

    public string descripcion { get; set; }

    public string version { get; set; }

    public string alcance { get; set; }

    public Nullable<int> id_responsable { get; set; }

    public string borrado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FacturasDetalle> FacturasDetalles { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PlanesDePrueba> PlanesDePruebas { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Usuario Usuario { get; set; }

}

}
