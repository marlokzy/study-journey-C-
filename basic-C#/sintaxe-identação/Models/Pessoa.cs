using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic_C_.Models // como se fosse o endereço do arquivo
{
    public class Pessoa // criamos a classe
    {
        public string Nome { get; set; } // criação das propriedades que essa classe terá
        public int Idade { get; set; }

        public void Apresentar(){ // criamos o método
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade}"); // Imprindo com interpolação
            
        }
    }
}