using Calculadora.Services;
namespace TestProject1;

public class CalculadoraTeste{

    private CalculadoraImp _calc;
    public CalculadoraTeste(){
        _calc = new CalculadoraImp();   
    }

    [Fact]
    public void Somar5e10(){
        //Arrange
        int n1 = 5;
        int n2 = 10;

        //Act
        int resultado = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(15,resultado);
    }
}