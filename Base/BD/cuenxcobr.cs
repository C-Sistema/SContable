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
    
    public partial class cuenxcobr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cuenxcobr()
        {
            this.pagoxclie = new HashSet<pagoxclie>();
        }
    
        public int id_cuxco { get; set; }
        public Nullable<decimal> monto_cuxco { get; set; }
        public decimal saldo_cuxco { get; set; }
        public Nullable<decimal> abonado_cuxco { get; set; }
        public Nullable<System.DateTime> fecha_cuxco { get; set; }
        public System.DateTime fechaxvenc_cuxco { get; set; }
        public Nullable<bool> pagado_cuxco { get; set; }
        public Nullable<bool> estado_cuxco { get; set; }
        public Nullable<int> id_ven { get; set; }
        public Nullable<int> id_mon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagoxclie> pagoxclie { get; set; }
        public virtual moneda moneda { get; set; }
        public virtual venta venta { get; set; }
    }
}
