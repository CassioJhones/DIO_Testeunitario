namespace ConsoleApp;

/// <summary>
/// Classe onde é realizada todas as operações matematicas
/// </summary>
public class CalculadoraImp
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    /// <summary>
    /// Realiza a subtração de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    /// <summary>
    /// Realiza a divisão de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

    /// <summary>
    /// Realiza a multiplicação de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <param name="n2">Segundo Numero</param>
    /// <returns></returns>
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    /// <summary>
    /// Realiza a verificação de dois numeros recebidos
    /// </summary>
    /// <param name="n1">Primeiro Numero</param>
    /// <returns>Verdadeiro ou Falso</returns>
    public bool ImparPar(int num)
    {//verifica par impar
        return num % 2 == 0;
    }
}