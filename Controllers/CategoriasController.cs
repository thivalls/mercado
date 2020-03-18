using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mercado.Data;
using mercado.DTO;
using mercado.Models;

namespace mercado.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext database;

        public CategoriasController(ApplicationDbContext database) {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Store(CategoriaDTO categoriaDTO) {
            if(ModelState.IsValid){
                Categoria categoria = new Categoria();
                categoria.Nome = categoriaDTO.Nome;
                categoria.Status = true;
                database.Categorias.Add(categoria);
                database.SaveChanges();
                return RedirectToAction("Categorias","Gestao");
            }else {
                return View("../Gestao/NovaCategoria");
            }
            return Content(categoriaDTO.Nome);
        }

        [HttpPost]
        public IActionResult Update(CategoriaDTO categoriaDTO) {
            if(ModelState.IsValid){
                var categoria = database.Categorias.First(cat => cat.Id == categoriaDTO.Id);
                categoria.Nome = categoriaDTO.Nome;
                database.SaveChanges();
                return RedirectToAction("Categorias","Gestao");
            }else {
                return View("../Gestao/NovaCategoria");
            }
            return Content(categoriaDTO.Nome);
        }

        [HttpPost]
        public IActionResult Deletar(int id) {
            var categoria = database.Categorias.First(cat => cat.Id == id);
            categoria.Status = false;
            database.SaveChanges();
            return RedirectToAction("Categorias","Gestao");
        }
    }
}