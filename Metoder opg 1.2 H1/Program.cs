using System;

namespace Metoder_opg_1._2_H1
{
    class Program
    {
        static void Main(string[] args)
        {
                 /*2.	Indtast 2 heltal i konsollen og:
                        - Brug Pythagoras’ sætning (a² + b² = c²) til at udregne c. 
                        - Hvilket tal er egentlig størst – a eller b? – output resultatet med hjælp fra en if-sætning. */

            double a = GetTal("Indtast en værdi for a");//opretter variabel og tildeler den værdien fra brugeren (konverteret)
            
            double b = GetTal("Indtast en værdi for b"); 

            Console.WriteLine("\n" + "c = " + GetHypotenuse(a, b) + "\n");/*udskriver resultatet vhja metodekald hvor variablerne med 
                                                                  * brugerens input sendes med*/
            StørsteTal(a, b);//metodekald til at udskrive den største værdi

            Console.ReadKey();//"Fastholder" programmet

        }
        //opretter metode med returværdi, der skal sendes en string med ved metodekaldet i Main
        public static double GetTal(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());//returnerer en double med værdien af brugerens indtastning (konverteret fra string)
            

        }
        //opretter metode med returværdi, tager to variabler med fra metodekaldet
        public static double GetHypotenuse(double a, double b) 
        {
            double resultat = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)),2);/*bruger indbyggede metoder til kvadratrod
                                                                                        * potens og afrunding*/
            return resultat;
        }
        //opretter metode til at tjekke hvilket tal der er størst
        public static void StørsteTal(double a, double b) 
        {
            if (a > b)
            {
                Console.WriteLine("a er større end b");
            }
            else
            {
                Console.WriteLine("b er større end a");
            }

        }
    }
}
