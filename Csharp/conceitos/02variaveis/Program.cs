//Variável String
string nome = "João";

//Variável Inteira
int idade = 20;

//Variável Decimal
decimal altura = 1.80m;

//Variável Booleana
bool maiorDeIdade = true;

//Variável Char - Armazena apenas uma letra e deve se usar os apóstrofos para declaração
char sexo = 'M';

//Variável Double
double peso = 80.5;

//Variável Float
float salario = 1500.50f;

//Variável DateTime
DateTime dataNascimento = new DateTime(2000, 01, 01);

//Variável Object
object obj = "Objeto";

//Variável Dynamic
dynamic dinamico = "Dinâmico";

//Variável Array
int[] numeros = { 1, 2, 3, 4, 5 };

//Variável List
List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

//Variável Dictionary
Dictionary<string, string> dicionario = new Dictionary<string, string>()
{
    { "Nome", "João" },
    { "Idade", "20" }
};

//Variável Tuple
var tupla = new Tuple<string, int, decimal>("João", 20, 1.80m);

//Variável ValueTuple
var tuplaValor = ("João", 20, 1.80m);

//Variável Enum
enum DiasDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

DiasDaSemana dia = DiasDaSemana.Domingo;

//Variável Struct
struct Pessoa
{
    public string Nome;
    public int Idade;
    public decimal Altura;
}

Pessoa pessoa;
pessoa.Nome = "João";
pessoa.Idade = 20;
pessoa.Altura = 1.80m;

//Variável Class
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public decimal Altura { get; set; }
}

Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";
pessoa.Idade = 20;

//Variável Interface
interface IPessoa
{
    string Nome { get; set; }
    int Idade { get; set; }
    decimal Altura { get; set; }
}