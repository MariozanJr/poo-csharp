using System;
using System.Globalization;


namespace Funcionario_Media
{

    public class Program
    {
        static void Main(string[] args)

        {

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();


            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            f1.Salario = float.Parse(Console.ReadLine());


            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            f2.Salario = float.Parse(Console.ReadLine());


            float media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine();
            Console.WriteLine($"A média salarial é: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
