//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Activos_PrestamosOET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivosUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivosUser()
        {
            this.PRESTAMOes = new HashSet<PRESTAMO>();
            this.PRESTAMOes1 = new HashSet<PRESTAMO>();
        }
    
        public string Id { get; set; }
        public string Email { get; set; }
        public Nullable<bool> EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> PhoneNumberConfirmed { get; set; }
        public Nullable<bool> TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public Nullable<bool> LockoutEnabled { get; set; }
        public Nullable<int> AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string EstacionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESTAMO> PRESTAMOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESTAMO> PRESTAMOes1 { get; set; }
    }
}
