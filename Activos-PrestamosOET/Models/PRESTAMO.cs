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
    using System.ComponentModel.DataAnnotations;
    public partial class PRESTAMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESTAMO()
        {
            this.EQUIPO_SOLICITADO = new HashSet<EQUIPO_SOLICITADO>();
            this.ACTIVOes = new HashSet<ACTIVO>();
        }

        [Display(Name = "Id de la boleta")]
        public string ID { get; set; }
        [Display(Name = "Número de boleta")]
        public Nullable<decimal> NUMERO_BOLETA { get; set; }
        [Display(Name = "Motivo")]
        [Required(ErrorMessage = "Por favor ingrese un motivo válido")]
        public string MOTIVO { get; set; }
        [Display(Name = "Fecha de solicitud")]
        public Nullable<System.DateTime> FECHA_SOLICITUD { get; set; }
        [Display(Name = "Fecha de retiro")]
        [Required(ErrorMessage = "Por favor ingrese una rango válido")]
        public Nullable<System.DateTime> FECHA_RETIRO { get; set; }
        [Display(Name = "Periodo del préstamo")]
        public Nullable<decimal> PERIODO_USO { get; set; }
        [Display(Name = "Software requerido")]
        public string SOFTWARE_REQUERIDO { get; set; }
        [Display(Name = "Observaciones del Solicitante")]
        public string OBSERVACIONES_SOLICITANTE { get; set; }
        [Display(Name = "Observaciones al aprobar el préstamo")]
        public string OBSERVACIONES_APROBADO { get; set; }
        [Display(Name = "Observaciones al recibir el préstamo")]
        public string OBSERVACIONES_RECIBIDO { get; set; }
        [Display(Name = "Sigla del curso")]
        public string SIGLA_CURSO { get; set; }
        public short Estado { get; set; }
        [Display(Name = "Cédula del solicitante")]
        public string CED_SOLICITA { get; set; }
        [Display(Name = "Cédula de quién aprueba")]
        public string CED_APRUEBA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPO_SOLICITADO> EQUIPO_SOLICITADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVO> ACTIVOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
    }
}
