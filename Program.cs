using System;
using System.Globalization;

namespace Fixacao.Vetores.Matrizes.Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetores --------------------------------------------------------

            //Console.WriteLine("Entre com a quantidade de valores: ");
            //int x = int.Parse(Console.ReadLine());

            //double[] vect = new double[x];

            //for (int i = 0; i < x; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double soma = 0.0;

            //for (int i = 0; i < x; i++)
            //{
            //    soma = soma + vect[i];
            //}

            //double avg = soma / x;
            //Console.WriteLine("AVG: " + avg.ToString("F2"));

            //Vetores -----------------------------------------------------------

            //Console.WriteLine("Entre  com o valor de um numero: ");
            //int x = int.Parse(Console.ReadLine());

            //Produto[] vect = new Produto[x];

            //for(int i = 0; i < x; i++)
            //{
            //    string nome = Console.ReadLine();
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Produto(nome, preco);
            //}

            //double soma = 0.0;

            //for(int i = 0; i < x; i++)
            //{
            //    soma = soma + vect[i].Preco;
            //}

            //double avg = soma / x;

            //Console.WriteLine("AVG: "+ avg.ToString("F2", CultureInfo.InvariantCulture));

            //Vetores--------------------------------------------------------------------------

            //Console.Write("Quantos quartos serão alugados?:  ");
            //int estudantes = int.Parse(Console.ReadLine());

            //Estudante[] vect = new Estudante[10];

            //for (int i = 1; i <= estudantes; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Aluguel# {i}:");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Quarto: ");
            //    int quartoAlugado = int.Parse(Console.ReadLine());
            //    vect[quartoAlugado] = new Estudante(nome, email);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Quartos ocupados: ");

            //for (int i = 0; i < 10; i++)
            //{
            //    if (vect[i] != null) // Para saber quais quartos estao ocupados dentro do vetor
            //    {
            //        Console.WriteLine(i + ":" + vect[i]);
            //    }
            //}

            //-----------------------------------------------------------------------

            //LAÇO FOREACH

            //string[] vect = new string[] { "Maria", "Paulo", "João" };

            //for(int i = 0; i < vect.Length; i++)  // tradicional usando "for"
            //{
            //    Console.WriteLine(vect [i]);
            //}

            //Console.WriteLine("-----------------------");

            //foreach( string obj in vect)  //  Usando "Foreach"
            //{
            //    Console.WriteLine(obj);
            //}

        }
    }
}
