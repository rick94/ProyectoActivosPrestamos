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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Web.Models.Validation;

    public partial class PRESTAMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESTAMO()
        {
            this.EQUIPO_SOLICITADO = new HashSet<EQUIPO_SOLICITADO>();
            this.ACTIVOes = new HashSet<ACTIVO>();
        }
        
        public string ID { get; set; }
        //[DisplayName("Id del préstamo")]
        [DisplayName("Número de boleta")]
        public Nullable<long> NUMERO_BOLETA { get; set; }
        
        [DisplayName("Motivo")]
        //[StringLength(250)]
        public string MOTIVO { get; set; }
        [DisplayName("Fecha de solicitud")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime FECHA_SOLICITUD { get; set; }
        [DisplayName("Inicio del préstamo")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "La fecha de inicio del préstamo es requerida")]
        [DateMustBeEqualOrGreaterThanCurrentDateValidation]
        public System.DateTime FECHA_RETIRO { get; set; }
        [DisplayName("Periodo del préstamo")]
        [Required(ErrorMessage = "El periodo de uso es requerido")]
        [Range(1, 99,
            ErrorMessage = "El periodo de uso debe ubicarse entre 1 y 99 días")]
        public int PERIODO_USO { get; set; }
        [DisplayName("Software requerido")]
        [StringLength(250)]
        public string SOFTWARE_REQUERIDO { get; set; }
        [DisplayName("Observaciones del solicitante")]
        [StringLength(250)]
        public string OBSERVACIONES_SOLICITANTE { get; set; }
        [DisplayName("Obervaciones al aprobar")]
        [StringLength(250)]
        public string OBSERVACIONES_APROBADO { get; set; }
        [StringLength(250)]
        [DisplayName("Observaciones al finalizar el préstamo")]
        public string OBSERVACIONES_RECIBIDO { get; set; }
        [DisplayName("Sigla del curso")]
        public string SIGLA_CURSO { get; set; }
        [DisplayName("Estado")]
        public short Estado { get; set; }
        [DisplayName("Cédula del solicitante")]
        public string CED_SOLICITA { get; set; }
        [DisplayName("Cédula de quien aprueba")]
        public string CED_APRUEBA { get; set; }        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPO_SOLICITADO> EQUIPO_SOLICITADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVO> ACTIVOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
    }
}
