namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = 0;

            // schleife mit freier Bedingung
            while (test < 3)
            {
                Console.WriteLine("While");
                test++;
            }

            // Zaehlschleife
            // for (Initialisierung; Bedingung; Sprunggroesse)
            for (int count = 0; count < 5; count++)
            {
                Console.WriteLine("For");
            }

            /*
             * Laenge 4
             * 
             * xxxx
             * xxxx
             * xxxx
             * xxxx
             *
             */
            Console.WriteLine("\n\n\n");

            int seitenlaenge = 0;
            Console.WriteLine("Gebe die Seitenlänge des Quadrats an: ");

            seitenlaenge = int.Parse(Console.ReadLine());
            int reset = seitenlaenge;

            int form = 0;

            Console.WriteLine("Welche Form (3,4)?");
            form = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (form == 4)
            {

                int line = seitenlaenge;
                int lineSet = seitenlaenge;

                while (line > 0)
                {
                    while (seitenlaenge > 0)
                    {
                        if (line == lineSet || line == 1)
                        {
                            Console.Write("x");
                        }
                        else if (seitenlaenge == reset || seitenlaenge == 1)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        seitenlaenge--;
                    }
                    Console.WriteLine();
                    seitenlaenge = reset;
                    line--;
                }

            }

            if (form == 3)
            {

                int boden = seitenlaenge;

                while (boden > 0)
                {
                    for (int count = 0; count < boden; count++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                    boden--;
                }

            }
            if (form == 2)
            {

                int line = seitenlaenge;
                int lineSet = seitenlaenge / 2;

                while (line > 0)
                {
                    while (seitenlaenge > 0)
                    {
                        if (line == 1)
                        {
                            Console.Write("x");
                        }
                        else if (seitenlaenge == lineSet && line == seitenlaenge)
                        {
                            Console.Write("x");
                        }
                        else if (seitenlaenge == lineSet + 1 && line != seitenlaenge -1)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        seitenlaenge--;
                    }
                    Console.WriteLine();
                    seitenlaenge = reset;
                    line--;
                }

            }

        }

    }

}
