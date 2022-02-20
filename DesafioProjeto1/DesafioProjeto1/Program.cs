using DesafioProjeto1.src.entities;

namespace DesafioProjeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 12, "Knight", "Sword");
            Wizard whiteWizard = new Wizard("Jenica", 99, "White Wizard", "Potion", true);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", "Stick");
            Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", "Mind Control", true);

            Console.WriteLine($@"Characters:
{arus}
{whiteWizard}
{ninja}
{blackWizard}");
            Console.WriteLine($"{whiteWizard.Attack(7)} and {ninja.Defense(2)}");
            Console.WriteLine($"{blackWizard.Attack(3)} and {whiteWizard.Defense()}");
        }
    }
}
