﻿using LanchesWsa.Context;
using LanchesWsa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _contexto;

        public LancheRepository(AppDbContext contexto) => _contexto = contexto;

        public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contexto.Lanches.Where(p=> p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId) => _contexto.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

    }
}
