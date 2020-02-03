using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoAspNet.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required (ErrorMessage = "Informe seu nome")]
        [MaxLength(100, ErrorMessage ="O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }
        [Required (ErrorMessage ="Informe seu nome")]
        [MaxLength(50, ErrorMessage ="O Login deve ter até 50 caracteres")]
        public string Login { get; set; }
        [Required (ErrorMessage ="Informe sua senha")]
        [DataType(DataType.Password)]
        [MaxLength(100, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }
        [Required (ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirmar senha")]
        [MaxLength(100, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage ="A senha e a confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}