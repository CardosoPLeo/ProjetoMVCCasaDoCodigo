﻿using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository proddutoRepository;

        public PedidoController(IProdutoRepository proddutoRepository)
        {
            this.proddutoRepository = proddutoRepository;
        }

        public IActionResult Carrossel()
        {
            
            return View(proddutoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}