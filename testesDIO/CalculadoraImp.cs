namespace ConsoleApp;

/// <summary>
/// Classe onde � realizada todas as opera��es matematicas
/// </summary>
public class CalculadoraImp
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    /// <summary>
    /// Realiza a subtra��o de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    /// <summary>
    /// Realiza a divis�o de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

    /// <summary>
    /// Realiza a multiplica��o de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    /// <summary>
    /// Realiza a verifica��o de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <returns>Verdadeiro ou Falso</returns>
    public bool ImparPar(int num)
    {//verifica par impar
        return num % 2 == 0;
    }
}