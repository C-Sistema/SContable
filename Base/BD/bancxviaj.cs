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
    
    public partial class bancxviaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bancxviaj()
        {
            this.gasto = new HashSet<gasto>();
        }
    
        public int id_baxvi { get; set; }
        public Nullable<decimal> monto_baxvi { get; set; }
        public Nullable<decimal> saldo_baxvi { get; set; }
        public Nullable<bool> transferido_baxvi { get; set; }
        public Nullable<bool> estado_baxvi { get; set; }
        public Nullable<int> id_mon { get; set; }
        public Nullable<int> id_via { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gasto> gasto { get; set; }
        public virtual moneda moneda { get; set; }
        public virtual viaje viaje { get; set; }
    }
}
