using BankÖvning;
using System.Runtime.CompilerServices;

internal class Program
{
    static void Main(string[] args)
    {
        var personer = new Personer { Name = "Kalle", Age = 20 };
        var bankkonton = new Bankkonton { Name = "Savings account", AccountNumber = "123456789" };

        GetName(personer);
        GetName(bankkonton);       

        static void GetName(Nameable named)
        {
            Console.WriteLine(named.Name);
        }

        var personLista = new List<Personer>();
        var bankkontonLista = new List<Bankkonton>();

        personLista.Add(new Personer { Name = "Kalle", Age = 20 });
        personLista.Add(new Personer { Name = "Pelle", Age = 30 });
        personLista.Add(new Personer { Name = "Lisa", Age = 40 });

        bankkontonLista.Add(new Bankkonton { Name = "Kalle", AccountNumber = "123456789" });
        bankkontonLista.Add(new Bankkonton { Name = "Pelle", AccountNumber = "0987654321" });
        bankkontonLista.Add(new Bankkonton { Name = "Lisa", AccountNumber = "123456786" });

        Console.WriteLine("");
        FindPerson("Kalle", personLista);
        FindAccount("123456789", bankkontonLista);
        Console.WriteLine("Printa personlista:");
        PrintPersonList(personLista);
        Console.WriteLine("Printa banklista:");
        PrintAccountList(bankkontonLista);
        
        static void PrintAccountList(List<Bankkonton> bank)
        {
            foreach (var person in bank)
            {
                Console.WriteLine($"Person: {person.Name} has this account number: {person.AccountNumber}");
            }
        }

        static void PrintPersonList(List<Personer> personer)
        {
            foreach (var person in personer)
            {             
                    Console.WriteLine($"Person: {person.Name} is {person.Age} years old.");               
            }
        }

        static void FindPerson(string name, List<Personer> personer)
        {
            foreach (var person in personer)
            {
                if (person.Name == name)
                {
                    Console.WriteLine($"Person: {person.Name} is {person.Age} years old.");
                }
            }
        }

        static void FindAccount(string accountNumber, List<Bankkonton> bankkonton)
        {
            foreach (var bankkonto in bankkonton)
            {
                if (bankkonto.AccountNumber == accountNumber)
                {
                    Console.WriteLine($"Account: {bankkonto.Name} has account number {bankkonto.AccountNumber}.");
                }
            }
        }
    }
}