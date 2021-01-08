using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace EmpresaCardenuto.Models
{
    public class Contatos
    {
        [Required (ErrorMessage ="O nome completo deve ser informado")]
        [Display(Name= "Nome Completo")]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required(ErrorMessage ="O assunto e obrigatorio")]
        [MaxLength(30, ErrorMessage ="Maximo 30 caracteres")]
        public string Assunto { get; set; }

        [MaxLength(50,ErrorMessage ="Maximo de 50 caracteres")]
        public string Mensagem { get; set; }
    }
}