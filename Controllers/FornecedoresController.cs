using System;
using Microsoft.AspNetCore.Mvc;
using mercado.Data;
using mercado.DTO;
using mercado.Models;

namespace mercado.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly ApplicationDbContext database;

        public FornecedoresController(ApplicationDbContext database) {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Store(FornecedorDTO fornecedorDTO) {
            if(ModelState.IsValid){
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = fornecedorDTO.Nome;
                fornecedor.Email = fornecedorDTO.Email;
                fornecedor.Telefone = fornecedorDTO.Telefone;
                fornecedor.Status = true;
                database.Fornecedores.Add(fornecedor);
                database.SaveChanges();
                return RedirectToAction("Fornecedores","Gestao");
            }else {
                return View("../Gestao/NovoFornecedor");
            }
            return Content(fornecedorDTO.Nome);
        }
    }
}