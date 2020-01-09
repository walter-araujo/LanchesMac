﻿using LanchesMac.Models;
using LanchesMac.Repositories;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;

        }

        public IActionResult List(string categoria)
        {
            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoria = "Todos os Lanches";
            }
            else
            {
                if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Normal")).OrderBy(l => l.Nome);

                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Natural")).OrderBy(l => l.Nome);
                }

                categoriaAtual = _categoria;

            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);

        }

    }
}