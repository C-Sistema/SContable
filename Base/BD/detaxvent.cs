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
    
    public partial class detaxvent
    {
        public int id_dexve { get; set; }
        public Nullable<int> cantidad_dexve { get; set; }
        public decimal preciou_dexve { get; set; }
        public Nullable<decimal> preciot_dexve { get; set; }
        public Nullable<bool> estado_dexve { get; set; }
        public Nullable<int> id_ven { get; set; }
        public Nullable<long> id_lot { get; set; }
    
        public virtual lote lote { get; set; }
        public virtual venta venta { get; set; }
    }
}
