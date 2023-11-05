namespace TestProject1;
    public class StringsTestes{
        private ValidacoesStrings _validaStrings;
        public StringsTestes(){
            _validaStrings = new ValidacoesStrings();
        }

        [Fact]
        public void Contar3caracteres(){
        //Arrange
        string texto = "olá";
            //Act
            int resultado = _validaStrings.ContarCaracteres(texto);

        //Assert
        Assert.Equal(3, resultado);
        }
    }

