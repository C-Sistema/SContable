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
    
    public partial class gastxviaj
    {
        public int id_gaxvi { get; set; }
        public Nullable<System.DateTime> fecha_gaxvi { get; set; }
        public string no_gaxvi { get; set; }
        public string descripcion_gaxvi { get; set; }
        public Nullable<decimal> monto_gaxvi { get; set; }
        public Nullable<decimal> tcambio_gaxvi { get; set; }
        public Nullable<bool> estado_gaxvi { get; set; }
        public Nullable<int> id_via { get; set; }
        public Nullable<int> id_mon { get; set; }
        public Nullable<int> id_for { get; set; }
    
        public virtual formapago formapago { get; set; }
        public virtual moneda moneda { get; set; }
        public virtual viaje viaje { get; set; }
    }
}
