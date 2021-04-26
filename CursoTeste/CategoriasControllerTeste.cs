

using System.Threading.Tasks;
using CursoAPI.Controllers;
using CursoMVCa.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace CursoTeste
{
    public class CategoriasControllerTeste
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
 
        public CategoriasControllerTeste()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 3, Descricao = "Alimentos" };

            //Encinando o Moq o deve esperar de retorno
            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);

            //Encinando o Moq o deve esperar de retorno do medoto  categorias.FindAsync(1)
           //_mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);

        }

        [Fact]
        public async Task Get_Categoria()
        {
            //inicializa o controller da API que será testada passando o context
            var service = new CategoriasController(_mockContext.Object);

            //Metodo que sera testado: Deve Retornar uma ctegoria
            //var testeCategoria = await service.GetCategoria(1);

            //Verifica se conseguiu executar
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());

            //Assert.Equal(_categoria,testeCategoria);
        }
         
    }
}
