using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RzutMoneta
{
    public class Rzut
    {

        public int orzel
        {
            get
            {
                return orly;
            }
            }   
            
        public int reszka
        {
            get
            {
                return reszki;
            }
        }
        public int[] wartosci
        {
            get
            {
                return values;
            }
           
        }
    //  public  string ww;


        public Rzut()
        {
        }
        private int[] values;
        private int orly = 0;
        private int reszki = 0;

        public void Losowanie(int x)
        {
         
             if (x <= 0 || x> 5)
              {
              throw new ArgumentOutOfRangeException();
             }
            
            try
            {
                Random losuj = new Random();
                values = new int[x];
                for (int i = 0; i < x; i++)
                {
                    values[i] = losuj.Next(0, 2);

                }
            }
           
            catch (Exception e)
            {
             Console.WriteLine(e.Message);

            }

        }


        public void Wyniki()
        {
           
          //  Console.WriteLine("\nWykonano {0} rzutów monetą.", values.Length);
            Console.Write("\nWylosowano:");
            for (int j = 0; j < values.Length; j++)
            {
                int w = values[j];
                switch (w)
                {
                    case 0:
                        Console.Write("     "+"[RESZKA]");
                        break;
                    case 1:
                        orly += 1;
                        Console.Write("     "+"[ORZEŁ]");
                        break;
                    default:
                        continue;
                }
            }

            reszki = values.Length - orly;
            Console.WriteLine("\n\n" + $"ORZEŁ: {orly}");
            Console.WriteLine($"RESZKA: {reszki}");


        }

    }

}
