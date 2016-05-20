﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Activos_PrestamosOET.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nombre de rol")]
        public string Name { get; set; }
    }

    [NotMapped]
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        // Info personal:
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }

        [Display(Name = "Estacion")]
        public string EstacionID { get; set; }


        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}
