
// Descobrindo idade.
/*
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Qual ano você nasceu?");
int nascimento =  int.Parse(Console.ReadLine());
int year = 2023;
int age = year - nascimento;
Console.WriteLine(nome + ", sua idade é: " + age + " anos.");

if(age <= 18)
    {
    Console.WriteLine("Você é menor de idade");
    }    
 else 
    {
    Console.WriteLine("Você é maior de idade");
    }*/

class Program
{
    static void Main(string[] a)
    {
        string[] names = { "Dida", "Ervin", "Denilson"};

    if (string.Equals(names[0], "dida", StringComparison.OrdinalIgnoreCase)) // comparando ignorando maiúscol e minusculos  
    {
        Console.WriteLine("Igaul");
    }

        foreach (var name in names)
        {
           
                Console.WriteLine(name);
            
        }
    }
}


/*  comentários:

tipos mais comuns em c#:

bool
char
byte
int
long 
float
doble
decimal
string

*/





