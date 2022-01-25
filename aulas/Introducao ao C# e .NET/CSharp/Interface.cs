using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string nomeDono { get; set; }
        public string especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.nomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.especie = especie;
        }
    }
}
