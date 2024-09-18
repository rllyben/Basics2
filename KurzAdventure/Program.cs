namespace KurzAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = 1;
            // ivertierun
            // ~0b01101010
            //  0b10010101

            // binäres UND
            // 0b01101010
            // 0b10011101
            // ----------
            // 0b00001000

            // binäre ODER
            // 0b01101010
            // 0b10011101
            // -----------
            // 0b11111111

            // bit shiften
            // (WERT<<Anzahl)
            // (1<<3)
            // 0b00000001 << 3
            // 0b00001000

            // Ein bit in einem Byte setzten
            data = data | (1 << 3);
            data |= (1 << 3);

            // Ein bit wieder auf 0 setzten
            data = data & ~(1 << 3);
            data &= ~(1 << 3);
            // 0b00001000
            // ob00001000 &

            int temp = data & (1 << 3);
            if (temp < 0) { }

            // Variablen
            int gameStop = 1;
            int mainAction = 0;
            int newHappening = 0;
            int secondHappening = 0;
            int messer = 0;

            // Game schleife
            while (gameStop == 1)
            {
                // Leert Konsole
                Console.Clear();

                // mainAction abfrags Schleife
                while(mainAction == 0)
                {
                    Console.WriteLine("Du befindest dich in der Küche!");
                    Console.WriteLine("Was willst du tun?");
                    Console.WriteLine("1. Ich gehe in's Wohnzimmer      3. Ich gehe in den Flur");
                    Console.WriteLine("2. Ich gehe in den Garten        4. Ich durchsuche die Schublade");
                    Console.WriteLine("Exit with 0");

                    try
                    {
                        mainAction = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        mainAction = 9;
                    }
                    // Exeting if
                    if (mainAction == 0)
                    {
                        gameStop = 0;
                        break;
                    }
                    // Fehler if
                    if (mainAction != 0 && mainAction != 1 && mainAction != 2 && mainAction != 3 && mainAction != 4 || mainAction == 9)
                    {
                        Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                        mainAction = 0;
                    }

                }

                // erstes Mainaction if (Wohnzimmer)
                if (mainAction == 1)
                {
                    Console.Clear();

                    // Wohnzimmer abfrags Schleife
                    while(newHappening == 0)
                    {
                        Console.WriteLine("Du gehst in's Wohnzimmer!");
                        Console.WriteLine("Du bist im Wohnzimmer, was willst du tun?");
                        Console.WriteLine("1. Ich setze mich auf die Coutch         2. Ich streichel meine Katze");
                        Console.Write("3. Ich gehe in den Flur                  ");
                        if(messer == 1){Console.Write("4. Ich steche meine Katze ab\n");}
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            newHappening = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            newHappening = 9;
                        }
                        if (newHappening == 0)
                        {
                            mainAction = 0;
                            gameStop = 0;
                            break;
                        }
                        if (newHappening != 0 && newHappening != 1 && newHappening != 2 && newHappening != 3 && newHappening != 4 || newHappening == 4 && messer != 1 || newHappening == 9)
                        {
                            Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                            newHappening = 0;
                        }

                    }

                    // auf der Coutch sitzen
                    if (newHappening == 1)
                    {
                        Console.Clear();
                        // Coutch abfrage
                        while (secondHappening == 0)
                        {
                            Console.WriteLine("Du setzt dich auf die Coutch");
                            Console.WriteLine("Was willst du tun?");
                            Console.WriteLine("1. Ich streichel meine Katze         2. Ich gehe in den Flur");
                            if(messer == 1){Console.WriteLine("3. Ich steche meine Katze ab");}
                            Console.WriteLine("Exit with 0");

                            try
                            {
                                secondHappening = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                secondHappening = 9;
                            }
                            if (secondHappening == 0)
                            {
                                newHappening = 0;
                                mainAction = 0;
                                gameStop = 0;
                                break;
                            }
                            if (secondHappening != 0 && secondHappening != 1 && secondHappening != 2 && secondHappening != 3 || secondHappening == 3 && messer != 1 || secondHappening == 9)
                            {
                                Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                                secondHappening = 0;
                            }

                        }

                        if (secondHappening == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Du streichelst diene Katze");
                            Console.WriteLine("Glückwunsch! Du hast das Ziel des Spiels erreicht!");
                            secondHappening = 0;
                            newHappening = 0;
                            mainAction = 0;
                            gameStop = 0;
                        }

                        if (secondHappening == 2)
                        {
                            secondHappening = 0;
                            newHappening = 0;
                            mainAction = 3;
                        }

                        if (secondHappening == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Du stichst deine Katze ab!\n" +
                                              "Deine Katze ist tot, weshalb du keinen Sinn mehr in einem Leben siehst und dich auch abstichst!");
                            Console.WriteLine("Du bist tot\n" + "Game over!");

                            secondHappening = 0;
                            newHappening = 0;
                            mainAction = 0;
                            gameStop = 0;
                        }

                    }

                    if (newHappening == 2)
                    {
                        newHappening = 1;
                        secondHappening = 1;
                    }

                    if (newHappening == 3)
                    {
                        newHappening = 0;
                        mainAction = 3;
                    }

                    if (newHappening == 4)
                    {
                        newHappening = 1;
                        secondHappening = 3;
                    }

                }

                if (mainAction == 2)
                {
                    Console.Clear();
                    while (newHappening == 0)
                    {
                        Console.WriteLine("Du gehst in den Garten!");
                        Console.WriteLine("Du bist im Garten, was willst du tun?");
                        Console.WriteLine("1. Ich lege mich auf den Rasen           3. Ich gehe in's Wohnzimmer");
                        Console.WriteLine("2. Ich gehe in den Flur                  4. Ich grüße den Nachbarn");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            newHappening = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            newHappening = 9;
                        }
                        if (newHappening == 0)
                        {
                            mainAction = 0;
                            gameStop = 0;
                            break;
                        }
                        if (newHappening != 0 && newHappening != 1 && newHappening != 2 && newHappening != 3 || newHappening == 9)
                        {
                            Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                            newHappening = 0;
                        }

                    }

                    if (newHappening == 1)
                    {
                        Console.WriteLine("nö");
                        newHappening = 0;
                    }

                    if (newHappening == 2)
                    {
                        newHappening = 0;
                        mainAction = 3;
                    }

                    if (newHappening == 3)
                    {
                        newHappening = 0;
                        mainAction = 1;
                    }

                    if (newHappening == 4)
                    {
                        Console.WriteLine("Dein Nachbar grüßt zurück");
                        newHappening = 0;
                    }

                }

                if (mainAction == 3)
                {
                    Console.Clear();
                    while (newHappening == 0)
                    {
                        Console.WriteLine("Du gehst in den Flur");
                        Console.WriteLine("Du bist im Flur, was willst du tun?");
                        Console.WriteLine("1. Ich gehe in's Wohnzimmer          2. Ich gehe in den Garten");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            newHappening = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            newHappening = 9;
                        }
                        if (newHappening == 0)
                        {
                            mainAction = 0;
                            gameStop = 0;
                            break;
                        }
                        if (newHappening != 0 && newHappening != 1 && newHappening != 2 || newHappening == 9)
                        {
                            Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                            newHappening = 0;
                        }

                    }

                    if (newHappening == 1)
                    {
                        newHappening = 0;
                        mainAction = 1;
                    }

                    if (newHappening == 2)
                    {
                        newHappening = 0;
                        mainAction = 2;
                    }

                }

                if (mainAction == 4)
                {
                    Console.Clear();
                    while (newHappening == 0)
                    {
                        if (messer == 0) { Console.WriteLine("Du durchsuchst die Schublade und findest ein Messer"); }
                        if (messer == 1) { Console.WriteLine("Du durchsuchst die Schublade, nichst ist drinnen."); }
                        Console.WriteLine("Was willst du tun?");
                        Console.WriteLine("1. Ich gehe in's Wohnzimmer      3. Ich gehe in den Flur");
                        Console.Write("2. Ich gehe in den Garten        ");
                        if (messer == 0) { Console.Write("4. Ich nehme das Messer mit\n"); }
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            newHappening = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            newHappening = 0;
                        }
                        if (newHappening == 0)
                        {
                            mainAction = 0;
                            gameStop = 0;
                            break;
                        }
                        if (newHappening != 0 && newHappening != 1 && newHappening != 2 && newHappening != 3 && newHappening != 4 || newHappening == 4 && messer == 1 || newHappening == 9)

                        {
                            Console.WriteLine("Falsche Eingabe, bitte erneut versuchen:");
                            newHappening = 0;
                        }

                    }

                    if (newHappening == 1)
                    {
                        mainAction = 1;
                        newHappening = 0;
                    }

                    if(newHappening == 2)
                    {
                        mainAction = 2;
                        newHappening = 0;
                    }

                    if (newHappening == 3)
                    {
                        mainAction = 3;
                        newHappening = 0;
                    }

                    if (newHappening == 4 )
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du nimmst dir das Messer mit");
                        messer = 1;
                        mainAction = 0;
                        newHappening = 0;
                    }

                }

            }

        }

    }

}
