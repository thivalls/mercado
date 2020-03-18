using System.ComponentModel.DataAnnotations;

namespace mercado.DTO
{
    public class ProdutoDTO
    {
        [Required]
        public int Id {get; set;}
        
        [Required(ErrorMessage="Nome do produto é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome de produto muito grante, tente um nome menor!")]
        [MinLength(2, ErrorMessage="Nome de produto muito curto, tente um nome maior!")]
        public string Nome {get; set;}
        [Required(ErrorMessage="Categoria do produto é obrigatório!")]
        public int CategoriaID {get; set;}
        [Required(ErrorMessage="Fornecedor do produto é obrigatório!")]
        public int FornecedorID {get; set;}
        [Required(ErrorMessage="Preço de custo do produto é obrigatório!")]
        public float PrecoDeCusto {get; set;}
        [Required(ErrorMessage="Preço de venda do produto é obrigatório!")]
        public float PrecoDeVenda {get; set;}
        [Required(ErrorMessage="Tipo de unidade do produto é obrigatório!")]
        [Range(0,2,ErrorMessage="Tipo de unidade inválido!")]
        public int Medicao {get; set;}
    }
}