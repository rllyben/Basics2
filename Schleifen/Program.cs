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

            // Holes Quadrat
            if (form == 4)
            {

                int line = seitenlaenge;
                int lineSet = seitenlaenge;

                // Wiederholt Zeile
                while (line > 0)
                {
                    // Wiederholt Zeichen
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
                        // Füllt die Spaces im Quadrat
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

            // Rechtwinkliges Dreieck
            if (form == 3)
            {

                int boden = seitenlaenge;

                // Wiederholt Zeile
                while (boden > 0)
                {
                    // Wiederholt Zeichen
                    for (int count = 0; count < boden; count++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                    boden--;
                }

            }

            // Gleichseitiges Dreieck
            if (form == 2)
            {
                int x = 1;
                int space = seitenlaenge;
                int line = seitenlaenge;

                while (space > 0)
                {

                    int durchlauf = 0;
                    // Wiederholt Zeichen
                    for (int count = 0; count < space; count++)
                    {
                        Console.Write(" ");

                        while (count == space - 1)
                        {
                            if (x == 1 || space == 1)
                            {
                                Console.Write(" x");
                                durchlauf++;
                            }
                            else if (durchlauf == 0 || durchlauf == x -1)
                            {
                                Console.Write(" x");
                                durchlauf++;
                            }
                            else
                            {
                                Console.Write("  ");
                                durchlauf++;
                            }

                            if (durchlauf >= x)
                            {
                                break;
                            }

                        }

                    }
                    Console.WriteLine();
                    space--;
                    x++;
                }

            }

            if (form == 1)
            {
                int dreieck1 = 1;
                float space = seitenlaenge;
                float space2 = space;
                float line = seitenlaenge * 2;
                float dreieck2 = space;
                float durchlauf22 = 0;
                float durchlauf23 = 0;

                while (line > 0)
                {

                    int durchlauf1 = 0;
                    int durchlauf2 = 0;
                    int leere1 = 0;
                    int leere2 = 0;
                    // Wiederholt Zeichen
                    for (float count = 0; count <= line; count++)
                    {
                        Console.Write(" ");

                        while (count == line - 1 && dreieck1 <= count)
                        {
                            if (dreieck1 == 1 || line == space +1 || durchlauf1 == 0 || durchlauf1 == dreieck1 -1)
                            { 
                                Console.Write(" x");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                            durchlauf1++;

                            if (durchlauf1 >= dreieck1)
                            {
                            break;
                            }

                        }

                        while (count == line - 1 && dreieck1 > count)
                        {
                            if (durchlauf2 == 0)
                            {
                                for (float count2 = space - durchlauf22; count2 <= space; count2++)
                                {
                                    if (count2 == space || count2 == space-durchlauf22 || line == 1)
                                    {
                                        Console.Write(" x");
                                    }
                                    else
                                    { 
                                        Console.Write("  ");
                                    }
                                }
                                durchlauf22++;
                                
                            }
                            else if (durchlauf2 < space2)
                            {
                                Console.Write("  ");
                            }
                            else if (durchlauf2+1 == dreieck1)
                            {
                                for (float count2 = space - durchlauf23; count2 <= space; count2++)
                                {
                                    if (count2 == space || count2 == space - durchlauf23 || line == 1)
                                    {
                                        Console.Write(" x");
                                    }
                                    else
                                    {
                                        Console.Write("  ");
                                    }
                                }
                                durchlauf23++;

                            }

                            durchlauf2++;

                            if (durchlauf2 >= dreieck1)
                            {
                                break;
                            }

                        }

                    }
                    Console.WriteLine();
                    if (dreieck1 > line)
                    {
                        space2--;
                    }
                    line--;
                    dreieck1++;
                }

            }

            if (form == 5)
            {
                double radius = seitenlaenge;

                for (double line = -radius; line <= radius; line++)
                {
                    for (double space = -radius; space < radius; space++)
                    {
                        double letter = (space / radius) * (space / radius) + (line / radius)*(line / radius);
                        if (letter > 0.4 && letter < 0.7)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

            }

            /*
             * 
             * x
             * xx
             * xxx
             *    x
             *   x x
             *  x x x
             * x x x x
             * 
             */


        }

    }

}
