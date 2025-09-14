using ExemploFundamentos.Models;

Pessoa/* Classe */ pessoa1 /*Nome da Variavel ou "pessoa que estamos criando"*/ = new Pessoa();
pessoa1.Idade = 18;
pessoa1.Nome = "Carlos";
pessoa1.Apresentar();
/*
    podemos fazer sem utilizar a using tbm ex.:
    ExemploFundamentos.Models.Pessoa = new ExemploFundamentos.Models.Pessoa();
*/

string apresentacao = "Olá, seja bem vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//Conversão de tipo de variavel - Esse método é chamado de CAST ou CASTING
//Utilizando o método Convert
int a = Convert.ToInt32("5");

//Utilizando o método Parse
int b = int.Parse("10");

/* Diferença entre Convert e Parse - O Convert converte vários tipos de dados
inclusive nulo, enquanto que o Parse converte apenas do tipo String

Conversão para String - Não precisa por o Convert na frente pois gera uma redundância de código. */

int c = 5;
string converte = c.ToString();

//Cast implicito
int d = int.MaxValue; //Recebe o valor máximo que o tipo inteiro permite.
long e = d;
double f = d;
Console.WriteLine(e);
Console.WriteLine(f.ToString("0.00"));

/*Convertemos sem utilizar o Convert e o Parse, pois a variavel do tipo int "cabe" nas váriaveis do tipo long e double.

Caso fosse do tipo long para int precisariamos realizar a conversão, pois ela não seria realizada implicitamente
oque iria gerar um erro no código.

Convertendo com o TryParse*/

string g = "15-";
int h = 0;

int.TryParse(g, out h);
Console.WriteLine(h);

string i = "15";

int.TryParse(i, out h);
Console.WriteLine(h);

/*O TryParse tenta converter caso não consiga que é o primeiro caso ele continua a rodar o 
código e caso consiga ele altera o valor da variável que foi o segundo caso.

No primeiro caso não converteu pois a string tinha um "-" e o tipo int aceita apenas números */

//Condicionais
int quantidadeEmEstoque = 10;
int quantidadeCompra = 5;
bool possivelVenda = quantidadeCompra >0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda) //Não precisa colocar == true pois gera redundância de código.
{
    Console.WriteLine("Venda realizada.");
}

else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

//Switch case

Console.WriteLine("Digite uma letra: ");
string? entrada = Console.ReadLine();

if (!string.IsNullOrEmpty(entrada))
{
    string letra = entrada.ToLower();
    switch (letra)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine($"{letra.ToUpper()} é uma vogal.");
            break;

        default:
            Console.WriteLine($"{letra.ToUpper()} não é uma vogal.");
            break;
    }
}
else
{
    Console.WriteLine("Nenhuma letra foi digitada.");
}

/* 
OU PODERIA SER FEITO DA SEGUINTE FORMA:
string letra = Console.ReadLine() ?? ""; //AS DUAS INTERROGAÇÕES É CHAMADA DE COALESCECIA NULA
//CONVERTE A ENTRADA NULA NO QUE ESTIVER ENTRE AS ASPAS DUPLA.

if (!string.IsNullOrEmpty(letra))
{
    letra = letra.ToLower();
    switch (letra)
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine($"{letra} é uma vogal.");
            break;

        default:
            Console.WriteLine($"{letra} não é uma vogal.");
            break;
    }
}
else
{
    Console.WriteLine("Nenhuma letra foi digitada.");
}
*/


//Operadores Lógicos
//Operador Ou (OR ou pipe "||")
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada!");
}

//Operador E (AND "&&")
double media = 7.5;
bool presencaMinima = true;

if (presencaMinima && media >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}

//Operador de Negação (NOT "!")

//Calculador - Operadores Aritmeticos

Calculadora calc = new Calculadora();

calc.Somar(10,30);
calc.Subtrair(30,10);
calc.Multiplicar(10, 30);
calc.Dividir(30, 10);

//Potencia
calc.Potencia(3, 3);

//Relações Trigonometricas
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

//Raiz quadrada
calc.RaizQuadrada(9);

//Incremento e Decremento

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10"); 
numeroIncremento = numeroIncremento + 1;
Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10");
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o 20");
numeroDecremento = numeroDecremento - 1;
Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o 20");
numeroDecremento--;
Console.WriteLine(numeroDecremento);

//Estruturas de repetição
//Laço de repetição FOR
int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}