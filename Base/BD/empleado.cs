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
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.bitacora = new HashSet<bitacora>();
            this.usuario = new HashSet<usuario>();
            this.venta = new HashSet<venta>();
        }
    
        public int id_emp { get; set; }
        public string nombre_emp { get; set; }
        public string apellido_emp { get; set; }
        public string cui_emp { get; set; }
        public System.DateTime fechai_emp { get; set; }
        public Nullable<System.DateTime> fechaf_emp { get; set; }
        public Nullable<System.DateTime> fechac_emp { get; set; }
        public string direccion_emp { get; set; }
        public string telefono_emp { get; set; }
        public string telefono2_emp { get; set; }
        public string correo_emp { get; set; }
        public bool estado_emp { get; set; }
        public Nullable<int> id_rol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bitacora> bitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
        public virtual rol rol { get; set; }
    }
}
