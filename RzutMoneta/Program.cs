using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RzutMoneta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String gra = "Tak";
      
            Console.WriteLine("Program symulujący rzut monetą");
           
            do
            {
                int LMonet=0;
                do
                {
                    Console.WriteLine("Ile monet? – wpisz liczbę w przedziale od 1 do 5");
                    String line = Console.ReadLine();
                    if (line == "") line = "1";

                    try
                    {
                        LMonet = Int32.Parse(line);
                         if (LMonet <= 0 || LMonet > 5) 
                          {
                              Console.WriteLine("!! Wprowadzona liczba jest spoza zakresu 1-5 !!");
                          }

                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("!! Wprowadzonym znakiem nie jest liczba całkowita !!");
                                    
                    }
              
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                                        }
               


                } while (LMonet < 1 || LMonet > 5);

           

                Rzut rz = new Rzut();
                rz.Losowanie(LMonet);
                rz.Wyniki();
                Console.WriteLine("\nCzy chcesz jeszcze raz zagrać? (wpisz \"Nie\" jeśli chcesz zakończyć),następnie zatwierdź)");
                if (Console.ReadLine()=="Nie")
                gra = "Nie";
            } while (gra == "Tak");
            Console.WriteLine("Dziękujemy za skorzystanie z programu" +
                " - aby zamknąć program naciśnij Enter");
            Console.ReadLine();
        }
    }
}
