using System.ComponentModel.DataAnnotations;

namespace mercado.DTO
{
    public class CategoriaDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="Nome de categoria obrigatório!")]
        [StringLength(100, ErrorMessage="Nome de categoria muito grante, tente um nome menor!")]
        [MinLength(2, ErrorMessage="Nome de categoria muito curto, tente um nome maior!")]
        public string Nome {get; set;}
    }
}