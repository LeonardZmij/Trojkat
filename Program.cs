namespace Trojkat
    // napisz klase trójkąt która zawiera 3 pola prywatne (boki trójkąta) dostęp do nich jest realizowany za pomocą geter i setert 
    // klasa zawiera nastepujące metody 
    // - sprawdza czy można zbudować trójkąt z wprowadzonych liczb 
    // - licząca pole za pomocą wzoru herona   
    // - obliczająca obwód 
    // - sprawdzająca i wyświetlająca czy trójkąt jest prostokątny, ostrokoątny czy rozwarto kątny za pomocą długości boków
    // program działa w pętli 1 - licz trójkąt 2 - wyjdź z programu
    // z obsługą błędów za pomocą catch excveptions dla wartości nie liczbowych oraz <= 0 
    // mają być dwie klasy  trojkat oraz program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trojkat trojkat = new Trojkat();
            while (true)
            {
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1 - Licz trójkąt");
                Console.WriteLine("2 - Wyjdź z programu");

                int wybor;
                if (!int.TryParse(Console.ReadLine(), out wybor))
                {
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    continue;
                }

                if (wybor == 2)
                {
                    break;
                }
                else if (wybor == 1)
                {
                    try
                    {
                        Console.Write("Podaj długość boku A: ");
                        trojkat.BokA = double.Parse(Console.ReadLine());

                        Console.Write("Podaj długość boku B: ");
                        trojkat.BokB = double.Parse(Console.ReadLine());

                        Console.Write("Podaj długość boku C: ");
                        trojkat.BokC = double.Parse(Console.ReadLine());

                        if (trojkat.CzyMoznaZbudowacTrojkat())
                        {
                            Console.WriteLine($"Obwód trójkąta: {trojkat.ObliczObwod():F2}");
                            Console.WriteLine($"Pole trójkąta: {trojkat.ObliczPole():F2}");
                            Console.WriteLine($"Typ trójkąta: {trojkat.SprawdzTypTrojkata()}");
                        }
                        else
                        {
                            Console.WriteLine("Nie można zbudować trójkąta z podanych boków.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wprowadź poprawną wartość liczbową.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                }
            }
        }
    }
}

