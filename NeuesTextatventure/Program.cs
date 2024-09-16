namespace Textatventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameStop = 1;
            int mainAction = 0;
            int newHappening = 0;
            int secondHappening = 0;
            int thirdHappening = 0;

            while(gameStop == 1)
            {

                while(mainAction == 0)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Morriton Mannor");
                    Console.ResetColor();
                    Console.WriteLine("London im Jahre 1874 die Stadt wächst unaufhaltsam und Volk leidet.\n" +
                                      "Das verschwinden vieller Handwerkszweige aufgrund der seit Jahrzehnten rasand vorrannschreitenden Industrialisierung,\n" +
                                      "treibt mehr und mehr Arbeiter in die Fabriken, wo Bedingungen herschen die der Sklaverei nicht unaehnlich sind.\n" +
                                      "Sie leben in dreckigen Slumms rund um die voellig verkommene Stadt\n" + 
                                      "und können nur hin und wieder einen Blick auf den Glanz erhaschen,\n" + 
                                      "in dem der besser gestellte Teil der Bevölkerung sein suesses Dasein fristet,\n" +
                                      "Wissenschaft, Wirtschaft und Technologie florieren waehrend der Mensch auf der Strecke zu bleiben droht.\n" +
                                      "In diesem Molloch oder besser gesagt am schönen Rande davon lebt auch ihr.\n");
                    Console.WriteLine("Geht euren Geschaefften nachm, versucht zu überleben und mitzuhalten im Rennen um die bessten Plätze oder besetzt sie berreits.\n" +
                                      "Alltag, wenn man es so nennen will. Doch werdet ihr an einem verregneten Tag etwas aussergewoehnliches erleben.\n");
                    Console.WriteLine("An einem verregneten Lonndoner Morgen erreicht euch ein Brief in dem steht:");
                    Console.WriteLine("\n");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                                                                                                 \n" +
                                      "Alter Freund.                                                                                    \n" +
                                      "                                                                                                 \n" +
                                      "Ich hoffe dieses Schreiben erreicht dich bei besster Gesundheit.                                 \n" +
                                      "Ich habe mich all zu lang nicht bei dir gemeldet,                                                \n" +
                                      "doch gehen mir in den letzten Tagen unsere gemeinsammen Gespraeche nicht aus dem Kopf.           \n" +
                                      "Du erinnertest mich einst daran das Vernumft stehts die wichtigste aller Tugenden zu sein habe.  \n" +
                                      "Und doch komme ich an die Grenzen der meinigen.                                                  \n" +
                                      "Ich moechte fast sagen meines Verstandes. Ich fürchte mich.                                      \n" +
                                      "Verzeih mir, dass ich so in Raetzeln schreibe, doch was ich dir zu berichten habe verlangt       \n" +
                                      "eines persoenlichen Gespraeches.                                                                 \n" +
                                      "Ich bitte dich also mein Freund. Mache dich umgehend auf den Weg zu mir, nach Morriton Mannor.   \n" +
                                      "Eine Kutsche wird dich am Bahnhof Wisley abholen und das Tiket fuer einen Zug,                   \n" +
                                      "der noch am Heutigen Vormittag dort hin faehrt liegt diesem Schreiben bei.                       \n" +
                                      "                                                                                                 \n" +
                                      "                                                                                                 \n" +
                                      "                                                                                                 \n" +
                                      "In freudiger Erwahrtung deines Besuches,                                                         \n" +
                                      "Morriton                                                                                         \n" +
                                      "                                                                                                 \n" +
                                      "                                                                                                 \n" +
                                      "                                                                                                 ");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    Console.WriteLine("Euch schreibt ein Freund, denn Alfred Morriton ist kein fremder für euch\n" +
                                      "Er ist eine gehobene Gestallt unter den Londoner Bessergestellten,\n" +
                                      "einer der einst in wirklich herausragenden Reichtum lebte,\n" +
                                      "doch vor einigen Jahren quasi all seine Gemachenschafften\n" +
                                      "und seine Gesellschaften abgestossen und sich auf sein Landhaus zurueckgezogen hat.\n" +
                                      "Ihr habt doch seit dem wenig Kontackt gehabt,\n" +
                                      "Seid dementsprechend doch ein wenig verwundert, dass gerade er euch schreibt.\n" +
                                      "Doch als ihr noch ueberlegt, hoert ihr bereits eine Kutsche vor eurem Haus vorrollen,\n" +
                                      "Und so macht ihr euch auf den Weg.\n");    
                    Console.WriteLine("Angekommen auf Morriton fuehrt euch Battler Bruce in den Salon\n" + 
                                      "Bruce: \"Wenn Ihr mich fuer einen Moment entschuldigen wuerden, ich werde sofort den Tee anrichten.\"\n" +
                                      "Mit diesen Worten verlaesst Bruce den Raum.\n");
                    Console.WriteLine("Was willst du tun?\n" + 
                                      "1. Ich schaue mich um        2. Ich setze mich an den Tisch \n" +
                                      "\n\n9. (close the game)");


                    try
                    {
                        mainAction = int.Parse(Console.ReadLine());
                    }            
                    catch (Exception ex)
                    {          
                        Console.WriteLine(ex.Message);
                        mainAction = 0;
                    }
                    if (mainAction == 0 && mainAction != 1 && mainAction != 2 && mainAction != 9)
                    {  
                        Console.WriteLine("wrong input please try again:");
                        mainAction = 0;
                    }

                }


                if (mainAction == 1)
                {
                    Console.Clear();

                    do
                    {
                        while (newHappening == 0)
                        {
                        Console.WriteLine("Ihr Blickt euch um, Ihr seid in einem relativ grossen Raum, gut eingerichtet.\n" +
                                          "Die Moebel sind nicht neu aber auch noch lange nicht aus der Mode, alles ist hervorragend gepfelgt, sehr sauber,\n" +
                                          "auch der Salon macht einen durchaus repraesentativen eindruck, man moege auch schonmal edlere Sachen gesehen haben,\n" +
                                          "aber es gehoert schon zur edleren Gesellschaft.\n" +
                                          "Es ist ein sehr schoener Raum, es haengen Bilder an den Waenden,\n" +
                                          "unteranderem Bilder der Famillie, aber noch nicht der Morritons.\n" +
                                          "Zumindest nicht so wie Ihr Euch an Mister Morriton erinnert, keine Gestalt die Euch bekannt vorkommt.\n" +
                                          "Ein offener Kamin, es geht eine kleine Woellbung mit Glas vom Haus ab, man sieht\n" +
                                          "der Garten ist auch gut in Schuss, sher schoene Teppiche.\n" +
                                          "Man sieht Mr. Morriton hat auch Handel betrieben, denn es sind auch Teppiche aus anderen Laendern mit dabei.\n" +
                                          "Sehr schoene Moebel, viel aus Holz, Fuesse und schoen bestickt.\n" +
                                          "Und waehrend Ihr euch so umseht betritt eine Magt mit einem Silbertablett und dem Tee in den Haenden,\n" + 
                                          "zusammen mit Bruce den Raum.\n" +
                                          "Und als sie euch erblickt faellt ihr das Tablett aus der Hand.\n");
                        Console.WriteLine("Was macht Ihr also?\n" +
                                          "1. Ich gehe zu ihr hin und versuche ihr zu helfen              2. Ich beschwere mich ueber das Missgeschick der Magt\n" +
                                          "3. Ich ignoriere das Geschehen und setze mich an den Tisch.\n\n" +
                                          "9. back");
                            try
                            {
                                newHappening = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                newHappening = 0;
                            }
                            if (newHappening == 0 && newHappening != 9 )
                            {
                                Console.WriteLine("wrong input please try again:");
                                newHappening = 0;
                            }

                        }

                        if (newHappening == 1)
                        {
                            Console.Clear();

                            while (secondHappening == 0)
                            {
                                Console.WriteLine("Waehrend Ihr ihr helft, fluestert sie Euch zu:\n" +
                                                  "Elliot, Elliot er, er ist verschwunden, Ihr muesst ...\n" +
                                                  "Bruce:\"Ach, was ist hier denn geschehen!\" Erhebt Bruce ploetzlich die Stimme\n" +
                                                  "und unterbricht die Situatuion.\n" +
                                                  "Bruce:\"Sofie du! Unerhoert was dieses Ding sich hier erlaubt! Also!\"\n" +
                                                  "Nun wendet sich Bruce zu Euch:\"Verzeiht mir vielmals, wir bereiten Ihen sofort neuen Tee zu,\n" +
                                                  "Es ist ja schliesslich auch bald Abendessenszeit, Ich. aehh. Verzeihung, Verzeihung.\"\n" +
                                                  "Und beginnt den verschuetteten Tee weg zu machen.\n");
                                Console.WriteLine("Was wollt Ihr tun?\n" +
                                                  "1. Ich frage nochmal nach dem zugefluessterten           2. Ich gehe zurueck zum Tisch und setzte mich\n\n" +
                                                  "9. Zurueck");
                                try
                                {
                                    secondHappening = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    secondHappening = 0;
                                }
                                if (secondHappening == 0 && secondHappening != 9 )
                                {
                                    Console.WriteLine("wrong input please try again:");
                                    secondHappening = 0;
                                }

                            }

                            if (secondHappening  == 1)
                            {
                                Console.Clear();

                                while (thirdHappening == 0)
                                {
                                    Console.WriteLine("Magt:\"Ich aehm, Ich aehm, garnichts! Es tut mir Leid!\"" +
                                                      "Sagt sie waehrend sie immer wieder zu Bruce schaut und beginnt hasstig den Tee auf zu wischen.\n");
                                    Console.WriteLine("Was wollt Ihr tun?\n" +
                                                      "1. Ich frage nochmal nach dem zugefluessterten           2. Ich gehe zurueck zum Tisch und setzte mich\n\n" +
                                                      "9. Zurueck");
                                    try
                                    {
                                        thirdHappening = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {   
                                        Console.WriteLine(ex.Message);
                                        thirdHappening = 0;
                                    }
                                    if (thirdHappening == 0 && thirdHappening != 1 && thirdHappening != 2 && thirdHappening != 9 )
                                    {
                                        Console.WriteLine("wrong input please try again:");
                                        thirdHappening = 0;
                                    }

                                }

                                if (thirdHappening == 1)
                                {
                                    thirdHappening = 0;
                                }

                                if (thirdHappening == 2)
                                {
                                    thirdHappening = 0;
                                    secondHappening = 2;
                                }
                                    
                                if (thirdHappening == 9)
                                {
                                    thirdHappening = 0;
                                    secondHappening = 0;
                                    mainAction = 0;
                                }
                            }

                            if (secondHappening == 2)
                            {
                                Console.Clear();

                                while(thirdHappening == 0)
                                {
                                    Console.WriteLine("Ihr setzt Euch an den Tisch.\n" +
                                                      "In diesen Moment kommen Bruce und die Magt zurück in den Raum.\n" +
                                                      "Bruce: \"Das Essen wird bereits angerichtet.\"\n" +
                                                      "Sagt Bruce und sie fangen an Teller mit Abdeckungen hinzustellen und den Tisch einzureichten.\n");
                                    Console.WriteLine("Was wollt Ihr tun?\n" +
                                                      "1. Ich frage nochmal nach dem zugefluessterten           2. Ich gehe zurueck zum Tisch und setzte mich\n\n" +
                                                      "9. Zurueck");
                                    try
                                    {
                                        thirdHappening = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {   
                                        Console.WriteLine(ex.Message);
                                        thirdHappening = 0;
                                    }
                                    if (thirdHappening == 0 && thirdHappening != 1 && thirdHappening != 2 && thirdHappening != 9 )
                                    {
                                        Console.WriteLine("wrong input please try again:");
                                        thirdHappening = 0;
                                    }

                                }

                            }

                            if (secondHappening == 9)
                            {
                                secondHappening = 0;
                                mainAction = 0;
                            }

                        }

                        if (newHappening == 9)
                        {
                            newHappening = 0;
                            mainAction = 0;
                        }

                    }while(mainAction == 1);

                }

                if (mainAction == 2)
                {
                    Console.Clear();

                    do
                    {

                        Console.WriteLine("Du setzt dich an den Tisch im Salon und wartest auf den Tee.\n" +
                                          "Und waehrend Ihr euch so umseht betritt eine Magt mit einem Silbertablett und dem Tee in den Haenden,\n" + 
                                          "zusammen mit Bruce den Raum.\n" +
                                          "Und als sie euch erblickt faellt ihr das Tablett aus der Hand.\n");
                        Console.WriteLine("Was macht Ihr also?\n" +
                                          "1. Ich gehe zu ihr hin und versuche ihr zu helfen              2. Ich beschwere mich ueber das Missgeschick der Magt\n" +
                                          "3. Ich ignoriere das Geschehen.\n\n" +
                                          "9. back");
                        while (newHappening == 0)
                        {
                            try
                            {
                                newHappening = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                newHappening = 0;
                            }
                            if (newHappening == 0 && newHappening != 1 && newHappening != 9)
                            {
                                Console.WriteLine("wrong input please try again:");
                                newHappening = 0;
                            }

                        }

                        if (newHappening == 1)
                        {
                            mainAction = 1;
                            newHappening = 1;
                        }

                        if (newHappening == 9)
                        {
                            newHappening = 0;
                            mainAction = 0;
                        }

                    }while(mainAction == 2);

                }

                if (mainAction == 9)
                {
                    Console.Clear();
                    Console.WriteLine("closing the game ...");
                    gameStop = 0;
                    mainAction = 0;
                }

            }

        }

    }

}