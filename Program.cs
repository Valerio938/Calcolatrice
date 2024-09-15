using System.Linq.Expressions;

namespace CalcolatriceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool inserimentoAbilitato = true;

            while (inserimentoAbilitato)
            {

                Console.Write("benvenuto nella calcolatrice,\n" +
                    "Inserisci il primo numero O digita 'Q' per uscire:");

                string? userInput = Console.ReadLine();

                if (userInput is not null && userInput.Equals("Q"))
                {
                    inserimentoAbilitato = false;
                    Console.WriteLine("Sei uscito.");
                    break;
                }


                try
                {

                    int Num1 = Convert.ToInt32(userInput);
                    Console.Write("Inserisci l'operatore (+, -, *, /, ^, R: ");
                    string? Operatore = Console.ReadLine();

                    int Num2 = 0;


                    if (Operatore != "R")
                    {
                        Console.WriteLine("Inserisci il secondo numero:");
                        Num2 = Convert.ToInt32(Console.ReadLine());
                    }

                    int risultato = 0;

                    switch (Operatore)
                    {
                        case "+":
                            risultato = Num1 + Num2;
                            Console.WriteLine($"{Num1} + {Num2} è: {risultato}");
                            break;
                        case "-":
                            risultato = Num1 - Num2;
                            Console.WriteLine($"{Num1} - {Num2} è: {risultato}");
                            break;
                        case "*":
                            risultato = Num1 * Num2;
                            Console.WriteLine($"{Num1} * {Num2} è: {risultato}");
                            break;
                        case "/":
                            risultato = Num1 / Num2;
                            Console.WriteLine($"{Num1} / {Num2} è: {risultato}");
                            break;
                        case "^":
                            double potenza = Math.Pow(Num1, Num2);
                            Console.WriteLine($"{Num1} elevato alla {Num2} è: {potenza}");
                            break;
                        case "R":
                            double radiceQuadrata = Math.Sqrt(Num1);
                            Console.WriteLine($"La radice quadrata di {Num1} è {radiceQuadrata}");
                            break;


                    }
                }

                //eccezioni 

                catch (DivideByZeroException)
                {
                    Console.WriteLine("impossibile dividere 0");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Questo non è un numero");
                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Numero troppo grande");

                }

            }

        }

    }
}