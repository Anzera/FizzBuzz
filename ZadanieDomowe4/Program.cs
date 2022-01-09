using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze FizzBuzz! Zasady są proste:\nJeżeli wpiszesz liczbę podzielną przez 3 na ekarnie wyświetli się słowo 'Fizz'\nJeżeli wprowadzona liczba będzie podzielna przez 5 to na ekranie pojawi się słowo 'Buzz'\nJeżeli liczba będzie podzielna zarówno przez 3 i 5 na ekranie wyświetli się 'FizzBuzz'\nW przypadku gdy liczba nie będzie podzielna ani przez 3, ani przez 5 to wyświetli się wpisana przez Ciebie liczba.\n\nZaczynajmy! Wpisz liczbę:");
            FizzBuzz fizzBuzz = new FizzBuzz();

            while (true)
            {
                var number = fizzBuzz.GetNumber();
                Console.WriteLine(fizzBuzz.IsFizzBuzz(number));
                Console.WriteLine("Jeśli chcesz zakończyć wciśnij 't', w przeciwnym wypadku podaj kolejną liczbę:");
            }
        }
    }
}
