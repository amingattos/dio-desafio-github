using System;
using Interface;
using Enum;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();
            person.Nome = "Adriano";
            person.Estado = "SP";
            person.Idade = 24;

            var person2 = new Pessoa();
            person.Nome = "Lucas";
            person.Estado = "ES";
            person.Idade = 25;

            Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.nomeDono = "Adriano";
            animal.especie = "Cachorros";

            var meses = (Meses)0;
            Meses meses2 = Meses.Dezembro;
            Meses meses3 = (Meses)4;

            Console.WriteLine("Hello World!");
        }
    }
}
