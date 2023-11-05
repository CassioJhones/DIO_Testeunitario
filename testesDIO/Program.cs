using Calculadora.Services;

CalculadoraImp c1 = new CalculadoraImp();

int n1 = 5; 
int n2 = 25;

Console.WriteLine($"{n1} + {n2} = {c1.Somar(n1,n2)}");
Console.WriteLine($"{n1} - {n2} = {c1.Subtrair(n1,n2)}");
Console.WriteLine($"{n1} / {n2} = {c1.Dividir(n1,n2)}");
Console.WriteLine($"{n1} * {n2} = {c1.Multiplicar(n1,n2)}");