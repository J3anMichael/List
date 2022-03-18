using System;
using System.Collections.Generic;
using List;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crair Lista para armazenar nomes
            List<string> names = new List<string>();

            Console.Write("Quantos nomes a serem add a lista? ");
            int value = int.Parse(Console.ReadLine());

            // Adicionar nomes na lista
            for (int i = 0; i < value; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                names.Add(name);
            }

            // Acessar Lista
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
           
            // Ler Objeto
            Console.ReadKey();



            



        }
    }
}
