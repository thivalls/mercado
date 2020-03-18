namespace mercado.Models
{
    public class Promocao
    {
        public int Id {get; set;}
        public int Nome {get; set;}
        public Produto Produto {get; set;}
        public float Porcentagem {get; set;}
        public bool status {get; set;}
    }
}