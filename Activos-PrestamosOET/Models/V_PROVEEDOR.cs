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
    
    public partial class V_PROVEEDOR
    {
        public string IDPROVEEDOR { get; set; }
        public System.DateTime FECHAINGRESO { get; set; }
        public string NOMBRE { get; set; }
        public string RAZONSOCIAL { get; set; }
        public bool ESTADO { get; set; }
        public Nullable<int> TIPOCEDULA { get; set; }
        public string CEDULA { get; set; }
        public string TELEFONO { get; set; }
        public string FAX { get; set; }
        public string SITIOWEB { get; set; }
        public string CORREOELECTRONICO { get; set; }
        public bool LOCACION { get; set; }
        public string IDPAIS { get; set; }
        public string IDPROVINCIA { get; set; }
        public string DIRECCION { get; set; }
        public string IDFORMAPAGO { get; set; }
        public string IDPLAZO { get; set; }
        public Nullable<decimal> DESCUENTO { get; set; }
        public Nullable<decimal> INTERESMORA { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<bool> CONGELAR { get; set; }
        public System.DateTime CREADO { get; set; }
        public string CREADOR { get; set; }
        public System.DateTime MODIFICADO { get; set; }
        public string MODIFICADOR { get; set; }
        public string MONEDA { get; set; }
        public string NOMBRE_CORTO { get; set; }
    }
}