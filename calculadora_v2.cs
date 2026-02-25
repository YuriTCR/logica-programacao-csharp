using System;

class Calculadora
{
    static void Main()
    {
        ExibirMenu();
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== CALCULADORA V2 ===");

        double num1 = LerNumero("Digite o primeiro número: ");
        double num2 = LerNumero("Digite o segundo número: ");

        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int opcao = Convert.ToInt32(Console.ReadLine());

        double resultado = Calcular(opcao, num1, num2);

        Console.WriteLine($"\nResultado: {resultado}");
    }

    static double LerNumero(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDouble(Console.ReadLine());
    }

    static double Calcular(int opcao, double num1, double num2)
    {
        switch (opcao)
        {
            case 1:
                return num1 + num2;
            case 2:
                return num1 - num2;
            case 3:
                return num1 * num2;
            case 4:
                if (num2 != 0)
                    return num1 / num2;
                else
                {
                    Console.WriteLine("Erro: divisão por zero.");
                    return 0;
                }
            default:
                Console.WriteLine("Opção inválida.");
                return 0;
        }
    }
}
