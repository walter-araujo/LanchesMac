using LanchesWsa.Context;
using LanchesWsa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contexto;

        public CategoriaRepository(AppDbContext contexto) => _contexto = contexto;

        public IEnumerable<Categoria> Categorias => _contexto.Categorias;

    }
}
