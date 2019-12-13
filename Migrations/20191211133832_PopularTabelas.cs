using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES('NORMAL','Lanche preparado com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES('NATURAL','Lanche preparado com ingredientes integrais e naturais')");

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) VALUES('X-SALADA', 'Cheese Salada', 'Pão de Hamburger com gergelim, Alface, Hamburger e queijo de primeira qualidade', 18.50, 'http://www.macoratti.net/Imagens/lanches/lanchenormal.jpg', 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) VALUES('MISTO QUENTE', 'Misto Quente', 'Pão Francês crocante com Presunto e Queijo de primeira qualidade', 10.00, 'http://www.macoratti.net/Imagens/lanches/lanchenormal.jpg', 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) VALUES('X-BURGER', 'Cheese Burger', 'Pão de Hamburger com gergelim com Hamburger e queijo de primeira qualidade', 14.00, 'http://www.macoratti.net/Imagens/lanches/lanchenormal.jpg', 'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) VALUES('PEITO DE PERU', 'Peito de Peru', 'Pão Integral com Peito de e cenoura ralada com alface picado e iorgute natural', 20.00, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural1.jpg', 1, 1, 2)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) VALUES('ATUM', 'Atum', 'Pão Integral com Atum de primeira qualidade com alface picado e cebola', 22.50, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural1.jpg', 1, 1, 2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
