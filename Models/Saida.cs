using System;

namespace mercado.Models
{
    public class Saida
    {
        public int Id {get;set;}
        public Produto Produto {get;set;}
        public float valorDaVenda {get;set;}
        public DateTime Data {get;set;}
    }
}