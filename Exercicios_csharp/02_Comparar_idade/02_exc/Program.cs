using System;
using System.Globalization;

    namespace Exc_02_Comparar_idade
{
        class Program
        {
            static void Main(string[] args)
            {
                Pessoa p1, p2; 

                p1 = new Pessoa();
                    p2 = new Pessoa();

                Console.WriteLine("Dados da primeira pessoa:");
                Console.Write("Nome: ");
                p1.nome = Console.ReadLine();
                
                Console.Write("Idade: ");
                p1.idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados da segunda pessoa:");
                
                Console.Write("Nome: ");
                p2.nome = Console.ReadLine();
                
                Console.Write("Idade: ");
                p2.idade = int.Parse(Console.ReadLine());
                
                 if (p1.idade > p2.idade)
                {
                    Console.WriteLine("Pessoa mais velha: " + p1.nome);
                }
                else
                {
                    Console.WriteLine("Pessoa mais velha: " + p2.nome);
                }
            }
        }
    }
