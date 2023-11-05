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

    [Fact]
    public void Somar10e10(){
        //Arrange
        int n1 = 10, n2 = 10;
        //Act
        int resultado = _calc.Somar(n1, n2);
        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void Multiplicar10e10(){
        //Arrange
        int n1 = 10, n2 = 10;
        //Act
        int resultado = _calc.Multiplicar(n1, n2);
        //Assert
        Assert.Equal(100, resultado);
    }

    [Fact]
    public void VerificaParouImpar(){
        //Arrange
        int num = 10;
        //Act
        bool resultado = _calc.ImparPar(num);
        //Assert
        Assert.True(resultado, "É Par");
        //Assert.False(resultado, "É Impar");
    }
}