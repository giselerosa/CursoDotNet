Console.Write("Insira o seu nome: ");

string name = Console.ReadLine();

Console.WriteLine($"Olá {name}!");
Console.Write("Digite o ano do seu nascimento: ");

int year = int.Parse(Console.ReadLine());
int age = 2022 - year; // +, -, *, /

Console.WriteLine($"Você tem {age} anos.");

if (age >= 18) 
{
    Console.WriteLine("Você é maior de idade");
}
else 
{
    Console.WriteLine("Você não é maior de idade");
} 
