//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class liquidacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public liquidacion()
        {
            this.ajusxlote = new HashSet<ajusxlote>();
        }
    
        public int id_liq { get; set; }
        public Nullable<System.DateTime> fecha_liq { get; set; }
        public string observaciones_liq { get; set; }
        public Nullable<bool> esatdo_liq { get; set; }
        public Nullable<int> id_via { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ajusxlote> ajusxlote { get; set; }
        public virtual viaje viaje { get; set; }
    }
}