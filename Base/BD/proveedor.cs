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
    
    public partial class proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proveedor()
        {
            this.cuenxpaga = new HashSet<cuenxpaga>();
            this.viaje = new HashSet<viaje>();
        }
    
        public int id_pro { get; set; }
        public string nombre_pro { get; set; }
        public string direccion_pro { get; set; }
        public string cp_pro { get; set; }
        public string telefono1_pro { get; set; }
        public string telefono2_pro { get; set; }
        public string rfiscal_pro { get; set; }
        public Nullable<decimal> saldoq_pro { get; set; }
        public Nullable<decimal> saldod_pro { get; set; }
        public string extra_pro { get; set; }
        public Nullable<bool> estado_pro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuenxpaga> cuenxpaga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<viaje> viaje { get; set; }
    }
}