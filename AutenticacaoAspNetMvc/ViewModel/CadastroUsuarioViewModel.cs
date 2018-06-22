using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoAspNetMvc.ViewModel
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(100, ErrorMessage = "O nome deve ter ate 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(50, ErrorMessage = "O nome deve ter ate 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe seu senha")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "O nome deve ter ate 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe seu senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Comfirma senha")]
        [MinLength(6, ErrorMessage = "O nome deve ter ate 6 caracteres")]
        [Compare(nameof(Senha),ErrorMessage = "A senha e a  comfirmacao nao estao iguais")]
        public string ConfirmaSenha { get; set; }
    }
}