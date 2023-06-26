using Projeto_teste;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
    }
}