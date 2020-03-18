using System;
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

        [HttpPut]
        public IActionResult Update(CategoriaDTO categoriaDTO) {
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
    }
}