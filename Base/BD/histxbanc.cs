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
    
    public partial class histxbanc
    {
        public long id_hixba { get; set; }
        public Nullable<int> idx_hixba { get; set; }
        public string tabla_hixba { get; set; }
        public string acion_hixba { get; set; }
        public string no_hixba { get; set; }
        public string nombre_hixba { get; set; }
        public string descripcion_hixba { get; set; }
        public Nullable<decimal> saldoi_hixba { get; set; }
        public Nullable<bool> credito_debito_hixba { get; set; }
        public Nullable<decimal> monto_hixba { get; set; }
        public Nullable<decimal> saldof_hixba { get; set; }
        public Nullable<System.DateTime> fecha_hixba { get; set; }
        public Nullable<decimal> tcambio_hixba { get; set; }
        public Nullable<int> id_for { get; set; }
        public Nullable<int> id_ban { get; set; }
    
        public virtual banco banco { get; set; }
    }
}