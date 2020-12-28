using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    class Program
    {
        static bool _outsideLoop;
        static bool _insideLoop;
        const char _answerYes = 'y';
        const char _answerNo = 'n';
        static int _UserNumber;


        static Program()
        {
            _outsideLoop = true;
            _insideLoop = true;
        }

        /// <summary>
        /// Aplikacja z wykorzystaniem modulo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            Console.WriteLine("Witaj, wpisz liczbę do konsoli, a otrzymasz informację o niej.");



            while (_outsideLoop)
            {
                if (_insideLoop != true)
                {
                    _insideLoop = true;
                }

                try
                {
                    _UserNumber = int.Parse(Console.ReadLine());


                    if (_UserNumber % 2 == 0)
                    {
                        Console.WriteLine("Twoja liczba jest parzysta!");
                    }
                    else
                    {
                        Console.WriteLine("Twoja liczba jest nieparzysta!");
                    }


                }

                catch (Exception)

                {

                    Console.WriteLine("Wprowadzono nieprawidłowe dane");

                }

                Console.WriteLine("Jeśli chesz grać dalej wpisz literę : 'y' w przeciwnym razie wpisz literę 'n'");



                while (_insideLoop)
                {

                    try
                    {

                        var userAnswer = Console.ReadLine();

                        if (char.Parse(userAnswer) == _answerYes)
                        {

                            Console.WriteLine("W takim razie gramy dalej...");
                            _insideLoop = false;
                        }

                        else if (char.Parse(userAnswer) == _answerNo)
                        {

                            Console.WriteLine("Kończę grę...");
                            _insideLoop = false;
                            _outsideLoop = false;
                        }



                    }
                    catch (Exception)

                    {

                        Console.WriteLine("Wprowadzono nieprawidłowe dane");

                    }



                }



            }

            Console.ReadLine();
        }
    }
}
