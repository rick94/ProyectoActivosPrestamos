//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Activos_PrestamosOET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_ANFITRIONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public V_ANFITRIONA()
        {
            this.ACTIVOes = new HashSet<ACTIVO>();
        }
    
        public string ID { get; set; }
        public string NOMBRE { get; set; }
        public string SIGLAS { get; set; }
        public string MONEDA { get; set; }
        public string TIPOCAMBIO { get; set; }
        public decimal TIPOUSUARIO { get; set; }
        public string TIPOCAMBIO_CONTA { get; set; }
        public string MONEDA_CONTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVO> ACTIVOes { get; set; }
    }
}
