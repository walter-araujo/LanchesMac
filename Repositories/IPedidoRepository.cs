﻿using LanchesMac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Repositories
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);

    }
}
