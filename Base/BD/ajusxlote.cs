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
    
    public partial class ajusxlote
    {
        public int id_ajxlo { get; set; }
        public Nullable<System.DateTime> fecha_ajxlo { get; set; }
        public Nullable<int> cantidad_ajxlo { get; set; }
        public Nullable<bool> incremento_ajxlo { get; set; }
        public string descripcion_ajxlo { get; set; }
        public Nullable<bool> estado_ajxlo { get; set; }
        public Nullable<long> id_lot { get; set; }
        public Nullable<int> id_liq { get; set; }
    
        public virtual liquidacion liquidacion { get; set; }
        public virtual lote lote { get; set; }
    }
}