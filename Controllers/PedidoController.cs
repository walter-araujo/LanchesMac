﻿using LanchesMac.Models;
using LanchesMac.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Pedido pedido)
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            if (_carrinhoCompra.CarrinhoCompraItens.Count == 0)
            {
                ModelState.AddModelError("", "Seu Carrinho de Compras Não possui Itens!");
            }

            if (ModelState.IsValid)
            {
                _pedidoRepository.CriarPedido(pedido);                
                
                ViewBag.CheckoutCompletoMsg = "Obrigado pelo seu pedido! :) ";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                _carrinhoCompra.LimparCarrinho();

                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }

            return View(pedido);

        }

        public IActionResult CheckoutCompleto()
        {

            ViewBag.Cliente = TempData["Cliente"];
            ViewBag.Pedido = TempData["Pedido"];
            ViewBag.DataPedido = TempData["DataPedido"];
            ViewBag.ValorPedido = TempData["ValorPedido"];

            return View();
        }

    }
}