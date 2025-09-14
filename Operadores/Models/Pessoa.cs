using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    //Todo nome de classe precisa se iniciar com letra maiuscula e caso seja uma palavra composta a segunda palavra tambem se inicia com maiuscula ex.: PessoaFisica 
    public class Pessoa
    {
        // digite prop e aperte enter para criar um atributo / propriedade
        public string Nome { get; set; } //get pega um valor e set atribui um valor
        public int Idade { get; set; } //classe.metodo exemplo Pessoa.Nome ou Console.WriteLine, onde o console é a class e o WriteLine é o método
        //pode usar palavra reservada se colocar @ na frente ex.: @class ou @strint e etc.
        public void Apresentar() //método ou função
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}