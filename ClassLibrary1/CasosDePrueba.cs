//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CasosDePrueba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CasosDePrueba()
        {
            this.CiclosPruebaDetalles = new HashSet<CiclosPruebaDetalle>();
        }
    
        public int id_caso_prueba { get; set; }
        public int id_plan_prueba { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> id_responsable { get; set; }
        public Nullable<bool> borrado { get; set; }
    
        public virtual PlanesDePrueba PlanesDePrueba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CiclosPruebaDetalle> CiclosPruebaDetalles { get; set; }
    }
}
