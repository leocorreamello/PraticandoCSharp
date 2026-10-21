using System.Globalization;

namespace ExerciciosEPratica;

public class EstruturaCondicional
{
    public static void Ex1()
    {
        Console.WriteLine("--Exercicio 01--");

        int n1 = int.Parse(Console.ReadLine());

        if (n1 >= 0)
        {
            Console.WriteLine("NAO NEGATIVO");
        }
        else
        {
            Console.WriteLine("NEGATIVO");
        }
    }

    public static void Ex2()
    {
        Console.WriteLine("--Exercicio 02--");

        int n1 = int.Parse(Console.ReadLine());

        if (n1 % 2 == 0)
        {
           Console.WriteLine("PAR"); 
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }

    public static void Ex3()
    {
        Console.WriteLine("--Exercicio 03--");

        string[] numeros = Console.ReadLine().Split(" ");
        int n1 = int.Parse(numeros[0]), n2 = int.Parse(numeros[1]), aux = n2;
        
        if (n1 < n2)
        {
            n2 = n1;
            n1 = aux;
        }
        
        int div = n1 / n2;


        if (div * n2 == n1)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

    public static void Ex4()
    {
        Console.WriteLine("--Exercicio 04--");
        string[] horas = Console.ReadLine().Split(" ");
        int horaInicio = int.Parse(horas[0]), horaFinal = int.Parse(horas[1]), duracao, relogio24 = 24;

        if (horaInicio < horaFinal)
        {
            duracao = horaFinal - horaInicio;
        }
        else if (horaInicio > horaFinal)
        {
            duracao = (horaFinal + relogio24) - horaInicio;
        }
        else
        {
            duracao = relogio24;
        }
        
        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }

    public static void Ex5()
    {
        Console.WriteLine("--Exercicio 05--");
        string[] valores = Console.ReadLine().Split(" ");
        int cod = int.Parse(valores[0]), qtd = int.Parse(valores[1]);
        double cachorroQuent = 4, xSalada = 4.50, xBanco = 5, torradaSimples = 2, refri = 1.5, valorTotal = 0;

        if (cod == 1)
        {
            valorTotal = qtd * cachorroQuent;
        }
        else if (cod == 2)
        {
            valorTotal = qtd * xSalada;
        }
        else if (cod == 3)
        {
            valorTotal = qtd * xBanco;
        }
        else if (cod == 4)
        {
            valorTotal = qtd * torradaSimples;
        }
        else if (cod == 5)
        {
            valorTotal = qtd * refri;
        }
    
        Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    public static void Ex6()
    {
        Console.WriteLine("--Exercicio 06--");
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (n1 < 0.0 || n1 > 100.0 )
            Console.WriteLine("Fora de intervalo");
        else if (n1 <= 25.0)
            Console.WriteLine("Intervalo [0,25]");
        else if (n1 <= 50.0)
            Console.WriteLine("Intervalo [25,50]");
        else if (n1 <= 75.0)
            Console.WriteLine("Intervalo [50,75]");
        else
            Console.WriteLine("Intervalo [75,100]");
    }
    
    public static void Ex7()
    {
        Console.WriteLine("--Exercicio 07--");

        string[] valores = Console.ReadLine().Split(" ");
        double x = double.Parse(valores[0], CultureInfo.InvariantCulture), y = double.Parse(valores[1], CultureInfo.InvariantCulture);
    
        if (x == 0.0 && y == 0.0)
            Console.WriteLine("Origem");
        else if (x > 0.0 && y > 0.0)
            Console.WriteLine("Q1");
        else if (x > 0.0 && y < 0.0)
            Console.WriteLine("Q4");
        else if (x < 0.0 && y < 0.0)
            Console.WriteLine("Q3");
        else
            Console.WriteLine("Q2");
    }
    
    public static void Ex8()
    {
        Console.WriteLine("--Exercicio 08--");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), imposto;

        if (salario <= 2000.0)
            imposto = 0;
        else if (salario <= 3000.0)
            imposto = (salario - 2000.0) * 0.08;
        else if (salario <= 4500.0)
            imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
        else
            imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
        
        if (imposto == 0.0) {
            Console.WriteLine("Isento");
        }
        else {
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}