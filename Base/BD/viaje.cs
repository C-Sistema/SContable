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
    
    public partial class viaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public viaje()
        {
            this.bancxviaj = new HashSet<bancxviaj>();
            this.cuenxpaga = new HashSet<cuenxpaga>();
            this.gastxviaj = new HashSet<gastxviaj>();
            this.liquidacion = new HashSet<liquidacion>();
            this.lote = new HashSet<lote>();
            this.memorando = new HashSet<memorando>();
        }
    
        public int id_via { get; set; }
        public Nullable<System.DateTime> fecha_via { get; set; }
        public Nullable<short> no_via { get; set; }
        public string codigo_via { get; set; }
        public string factura_via { get; set; }
        public Nullable<System.DateTime> fechav_via { get; set; }
        public string piloto_via { get; set; }
        public string placas_via { get; set; }
        public Nullable<decimal> totalnf_via { get; set; }
        public Nullable<decimal> totalfi_via { get; set; }
        public Nullable<decimal> totalr_via { get; set; }
        public Nullable<decimal> tcambio_via { get; set; }
        public Nullable<System.DateTime> fechacerrado_via { get; set; }
        public Nullable<bool> cerrado_via { get; set; }
        public Nullable<bool> estado_via { get; set; }
        public Nullable<int> id_mon { get; set; }
        public Nullable<int> id_pro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bancxviaj> bancxviaj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuenxpaga> cuenxpaga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gastxviaj> gastxviaj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<liquidacion> liquidacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lote> lote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<memorando> memorando { get; set; }
        public virtual moneda moneda { get; set; }
        public virtual proveedor proveedor { get; set; }
    }
}
