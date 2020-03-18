using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using mercado.Data;
using mercado.DTO;
using mercado.Models;

namespace mercado.Controllers
{
    public class ProdutosController : Controller
    {

        private readonly ApplicationDbContext database;

        public ProdutosController(ApplicationDbContext database) {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Store(ProdutoDTO produtoDTO) {
            if(ModelState.IsValid){
                Produto produto = new Produto();
                produto.Nome = produtoDTO.Nome;
                produto.Categoria = database.Categorias.First(categoria => categoria.Id == produtoDTO.CategoriaID);
                produto.Fornecedor = database.Fornecedores.First(fornecedor => fornecedor.Id == produtoDTO.FornecedorID);
                produto.PrecoDeCusto = produtoDTO.PrecoDeCusto;
                produto.PrecoDeVenda = produtoDTO.PrecoDeVenda;
                produto.Medicao = produtoDTO.Medicao;
                produto.status = true;
                database.Produtos.Add(produto);
                database.SaveChanges();
                return RedirectToAction("Produtos","Gestao");
            }else {
                ViewBag.Categorias = database.Categorias.ToList();
                ViewBag.Fornecedores = database.Fornecedores.ToList();
                return View("../Gestao/NovoProduto");
            }
            return Content(produtoDTO.Nome);
        }
    }
}