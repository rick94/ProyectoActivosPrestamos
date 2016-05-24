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
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class ACTIVO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVO()
        {
            this.PRESTAMOes = new HashSet<PRESTAMO>();
            this.TRANSACCIONES = new HashSet<TRANSACCION>();

            //OJO: si se regenera el modelo esto muere. Tal vez seria mejor moverlo a otro archivo y aprovechar
            //que la clase es partial.            


            this.FECHA_INGRESO = DateTime.Now.Date; // Se le quema la fecha de ingreso
            this.ID = DateTime.Now.Day.ToString("D2") + DateTime.Now.Month.ToString("D2") + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString("D2") + DateTime.Now.Minute.ToString("D2") + DateTime.Now.Second.ToString("D2") + DateTime.Now.Millisecond.ToString("D3"); /// Se genera el ID con el estandar de la OET.

        }

        public string ID { get; set; }

        [Display(Name = "N�mero de serie")]
        public string NUMERO_SERIE { get; set; }

        [Display(Name = "Fecha de compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha de compra es requerido")]
        public System.DateTime FECHA_COMPRA { get; set; }

        [Display(Name = "Inicio de servicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> INICIO_SERVICIO { get; set; }

        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime FECHA_INGRESO { get; set; }

        [Display(Name = "Fabricante")]
        [Required(ErrorMessage = "Fabricante es requerido")]
        public string FABRICANTE { get; set; }

        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe tener un valor positivo")]
        [Required(ErrorMessage = "Precio es requerido")]
        public decimal PRECIO { get; set; }

        [Display(Name = "Descripci�n")]
        [DataType(DataType.MultilineText)]
        [StringLength(256, MinimumLength = 6, ErrorMessage = "El campo tiene que tener menos de 256 caracteres y m�s de 6.")]
        [Required(ErrorMessage = "Es necesario que ingrese una descripci�n del activo")]
        public string DESCRIPCION { get; set; }

        [Display(Name = "Exento de impuestos")]
        public bool EXENTO { get; set; }

        [Display(Name = "Sujeto a pr�stamos")]
        public bool PRESTABLE { get; set; }

        [Display(Name = "Tipo de capital")]
        public bool TIPO_CAPITAL { get; set; }


        [Display(Name = "Ingresado por")]
        //[Required(ErrorMessage = "Quien lo ingres� es requerido")]
        public string INGRESADO_POR { get; set; }

        [Display(Name = "N�mero de factura")]
        [Required(ErrorMessage = "N�mero de documento es requerido")]
        public string NUMERO_DOCUMENTO { get; set; }

        [Display(Name = "N�mero de lote")]
        public string NUMERO_LOTE { get; set; }

        [Display(Name = "Tipo de transacci�n")]
        [Required(ErrorMessage = "Tipo de transacci�n es requerido")]
        public int TIPO_TRANSACCIONID { get; set; }


        [Display(Name = "Estado")]
        public int ESTADO_ACTIVOID { get; set; }

        [Display(Name = "Tipo de activo")]
        [Required(ErrorMessage = "Tipo de activo es requerido")]
        public int TIPO_ACTIVOID { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string COMENTARIO { get; set; }

        [Display(Name = "Desechado")]
        public bool DESECHADO { get; set; }

        [Display(Name = "Modelo")]
        public string MODELO { get; set; }

        [Display(Name = "Usuario")]
        public string V_USUARIOSIDUSUARIO { get; set; }

        [Display(Name = "Estaci�n")]
        public string V_ESTACIONID { get; set; }

        [Display(Name = "Compa��a")]
        [Required(ErrorMessage = "Compa��a es requerido")]
        public string V_ANFITRIONAID { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "El proveedor es requerido")]
        public string V_PROVEEDORIDPROVEEDOR { get; set; }

        [Display(Name = "Tipo de moneda")]
        [Required(ErrorMessage = "El tipo de moneda es requerido")]
        public string V_MONEDAID { get; set; }

        [Display(Name = "Centro de Costo")]
        public Nullable<int> CENTRO_DE_COSTOId { get; set; }
        [Display(Name = "N�mero de placa")]
        [Required(ErrorMessage = "El n�mero de placa es requerido")]
        public string PLACA { get; set; }
        [Display(Name = "Estado del prestamo")]
        public Nullable<int> ESTADO_PRESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESTAMO> PRESTAMOes { get; set; }
        public virtual TIPOS_ACTIVOS TIPOS_ACTIVOS { get; set; }
        public virtual ESTADOS_ACTIVOS ESTADOS_ACTIVOS { get; set; }
        public virtual V_MONEDA V_MONEDA { get; set; }
        public virtual CENTROS_DE_COSTOS CENTROS_DE_COSTOS { get; set; }
        public virtual V_USUARIOS V_USUARIOS { get; set; }
        public virtual V_PROVEEDOR V_PROVEEDOR { get; set; }
        public virtual V_ANFITRIONA V_ANFITRIONA { get; set; }
        public virtual TIPOS_TRANSACCIONES TIPOS_TRANSACCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCION> TRANSACCIONES { get; set; }
        public virtual V_ESTACION V_ESTACION { get; set; }

        public string descripcion()
        {
            //TODO: cambiar los IDs por los nombres
            string esta_exento, capital, prestable;
            esta_exento = this.EXENTO ? "Exento" : "Gravado";
            capital = this.TIPO_CAPITAL ? "Capital mayor" : "Capital menor";
            prestable = this.PRESTABLE ? "Prestable" : "No prestable";

            string atributos = this.DESCRIPCION + "-";
            if (this.NUMERO_SERIE != null) atributos += this.NUMERO_SERIE + "-";
            if (this.MODELO != null) atributos += this.MODELO + "-";
            atributos += this.FABRICANTE + "-";
            if (this.NUMERO_LOTE != null) atributos += this.NUMERO_LOTE + "-";
            atributos += this.NUMERO_DOCUMENTO + "-" + this.PRECIO + "-" + esta_exento + "-" + capital + "-" +
                         this.V_PROVEEDORIDPROVEEDOR + "-" + this.FECHA_COMPRA.Date + "-";
            if (this.INICIO_SERVICIO != null) atributos += this.INICIO_SERVICIO + "-";
            atributos += prestable + "-";
            if (this.V_ESTACION != null) atributos += this.V_ESTACION.NOMBRE + "-";
            if (this.CENTROS_DE_COSTOS != null) atributos += this.CENTROS_DE_COSTOS.Nombre + "-";
            if (this.V_USUARIOS != null) atributos += "Responsable: " + this.V_USUARIOS.NOMBRE + "-";
            if (this.V_ESTACION != null) atributos += this.V_ESTACION.NOMBRE + "-";
            atributos += this.TIPO_TRANSACCIONID + "-" + this.V_ANFITRIONAID + "-";
            if (this.INGRESADO_POR != null) atributos += this.INGRESADO_POR + "-";
            atributos += this.FECHA_INGRESO;
            return atributos;
        }
    }
}