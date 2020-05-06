using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sebrae_app.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string NomeUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; }

    }
}