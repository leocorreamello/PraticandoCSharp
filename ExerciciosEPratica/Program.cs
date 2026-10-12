using System.Globalization;

namespace ExerciciosEPratica;

public class Program
{ 
    static void Main(string[] args)
    {
        Calculadora.Ex6();
    }
}

public class Calculadora 
{
    public static void Ex1()
    {
        Console.WriteLine("--EXERCICIO 01--");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
    
        Console.WriteLine($"SOMA = {n1 + n2}");
    }

    public static void Ex2()
    {
        Console.WriteLine("--EXERCICIO 02--");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area = 3.14159 * (raio * raio);
        
        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }

    public static void Ex3()
    {
        Console.WriteLine("--EXERCICIO 03--");
        int n1, n2, n3, n4;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        int diferencial = (n1 * n2) - (n3 * n4);
        Console.WriteLine($"DIFERENCIAL = {diferencial}");
    }

    public static void Ex4()
    {
        Console.WriteLine("--EXERCICIO 04--");
        int numeroFuncionario, horasTrabalhadas;
        numeroFuncionario = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double salario = horasTrabalhadas * valorHora;
        
        Console.WriteLine($"NUMBER = {numeroFuncionario} \nSALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

    }

    public static void Ex5()
    {
        Console.WriteLine("--EXERCICIO 05--");
        string[] valores = Console.ReadLine().Split(' ');
        int codigoPeca = int.Parse(valores[0]), quantidadePeca = int.Parse(valores[1]);
        double resultado1, valorPeca = double.Parse(valores[2], CultureInfo.InvariantCulture);
        resultado1 = quantidadePeca * valorPeca;
        
        valores = Console.ReadLine().Split(' ');
        codigoPeca = int.Parse(valores[0]);
        quantidadePeca = int.Parse(valores[1]);
        valorPeca = double.Parse(valores[2], CultureInfo.InvariantCulture);
        
        Console.WriteLine($"VALRO A PAGAR: R$ {(resultado1 + (valorPeca * quantidadePeca)).ToString("F2", CultureInfo.InvariantCulture)}");
    }

    public static void Ex6()
    {
        Console.WriteLine("--EXERCICIO 06--");
        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0], CultureInfo.InvariantCulture),
               b = double.Parse(valores[1], CultureInfo.InvariantCulture),
               c = double.Parse(valores[2], CultureInfo.InvariantCulture),
               pi = 3.14159;

        Console.WriteLine($"TRIANGULO: {(a * c / 2).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                         $"CIRCULO: {(pi * (c * c)).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                         $"TRAPEZIO: {((a + b) / 2 * c).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                         $"QUADRADO: {(b * b).ToString("F3", CultureInfo.InvariantCulture)}\n" +
                         $"RETANGULO: {(a * b).ToString("F3", CultureInfo.InvariantCulture)}");
    }
}