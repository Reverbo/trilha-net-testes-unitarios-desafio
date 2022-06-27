using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
         var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);


        // Assert
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
   public class MyTestClass
{
    [Theory]
    [InlineData(5, 10)] // Given input 5, expected output 10
    [InlineData(10, 20)] // Given input 10, expected output 20
    [InlineData(3, 6)] // Given input 3, expected output 6
    public void Test_GivenInput_WhenAction_ThenExpectedResult(int input, int expectedResult)
    {
        // When
        var result = SomeAction(input);

        // Then
        Assert.Equal(expectedResult, result);
    }

    private int SomeAction(int input)
    {
        // Implementação do comportamento que você está testando
        return input * 2; // Exemplo simples: multiplicar por 2
    }
}

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

         // Arrange
    var lista = new List<int> { 5, 7, 8, 9 };
    var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
    
    // Act
    var resultado = _validacoes.MultiplicarNumerosLista(lista);

    // Assert
    Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista;

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, 9);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
