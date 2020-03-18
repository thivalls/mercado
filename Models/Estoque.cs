namespace mercado.Models
{
    public class Estoque
    {
        public int Id {get;set;}
        public Produto Produto {get;set;}
        public float quantidade {get;set;}
    }
}