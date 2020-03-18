using System.ComponentModel.DataAnnotations;

namespace mercado.DTO
{
    public class FornecedorDTO
    {
        [Required]
        public int Id {get; set;}
        
        [Required(ErrorMessage="Nome do fornecedor é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome de fornecedor muito grante, tente um nome menor!")]
        [MinLength(2, ErrorMessage="Nome de fornecedor muito curto, tente um nome maior!")]
        public string Nome {get; set;}
        [Required(ErrorMessage="Email do fornecedor é obrigatório!")]
        [EmailAddress(ErrorMessage="Insira um email válido!")]
        public string Email {get; set;}
        [Required(ErrorMessage="Telefone do fornecedor é obrigatório!")]
        [Phone(ErrorMessage="Insira um número de telefone válido!")]
        public string Telefone {get; set;}
    }
}