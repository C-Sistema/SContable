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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.boton = new HashSet<boton>();
        }
    
        public int id_usu { get; set; }
        public string nombre_usu { get; set; }
        public string contrasena_usu { get; set; }
        public bool cambiarc_usu { get; set; }
        public bool permxpers_usu { get; set; }
        public bool estado_usu { get; set; }
        public Nullable<int> id_emp { get; set; }
    
        public virtual empleado empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boton> boton { get; set; }
    }
}