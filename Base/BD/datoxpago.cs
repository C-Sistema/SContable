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
    
    public partial class datoxpago
    {
        public int id_daxpa { get; set; }
        public string descripcion_daxpa { get; set; }
        public string dato1_daxpa { get; set; }
        public string dato2_daxpa { get; set; }
        public string dato3_daxpa { get; set; }
        public Nullable<bool> esatdo_daxpa { get; set; }
        public Nullable<int> id_paxpr { get; set; }
    
        public virtual pagoxprov pagoxprov { get; set; }
    }
}
