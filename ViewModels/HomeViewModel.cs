using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> lanchesPreferidos { get; set; }
    }
}
