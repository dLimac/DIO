using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    //Todo nome de classe deve se iniciar com letra maiuscula e caso seja nome composto o segundo nome precisa se iniciar com letra maiuscula tbm ex.: PessoaFisica
    public class Pessoa
    {
        //digite prop e aperte enter que já cria uma propriedade, que são as caracteristicas da classe
        public string Nome { get; set; } //GET PEGA UM VALOR E SET ATRIBUI UM VALOR EX.: No Console.WriteLine está exibindo um valor então é utilizado o GET se atribuirmos um valor ao atributo utiliza o SET.
        public int Idade { get; set; }
        // para chama um método sempre utilizamos classe.método ex.: Pessoa.Nome ou Console.WriteLine
        public void Apresentar()// Método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }//As chaves são utilizadas para iniciar e finalizar um bloco de código de um método, classe ou outro bloco de código
    }
}