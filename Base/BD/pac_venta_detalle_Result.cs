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
    
    public partial class pac_venta_detalle_Result
    {
        public long id_lot { get; set; }
        public Nullable<int> id_pro { get; set; }
        public string Producto { get; set; }
        public Nullable<int> id_tam { get; set; }
        public string Tamaño { get; set; }
        public Nullable<int> id_pre { get; set; }
        public string Presentacion { get; set; }
        public Nullable<int> Existencias { get; set; }
        public int Pedido { get; set; }
        public Nullable<decimal> Unitario { get; set; }
        public int Total { get; set; }
    }
}
