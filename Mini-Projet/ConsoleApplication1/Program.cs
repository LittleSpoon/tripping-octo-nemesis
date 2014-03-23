using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ligne Blanche
            WriteFullLineWhite(" ");
            Console.WriteLine(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("# # # # #    # # # #    # # # #    # # # # #");
            Console.WriteLine("    #        #          #              #    ");
            Console.WriteLine("    #        # # #      # # # #        #    ");
            Console.WriteLine("    #        #                #        #    ");
            Console.WriteLine("    #        # # # #    # # # #        #    " + Environment.NewLine + Environment.NewLine);
            Console.ResetColor();

            // Ligne Blanche
            WriteFullLineWhite(" ");

           //Ligne etoile 
            LineStarsBlue();

            //Menu
            Console.WriteLine(
            Environment.NewLine + "1. Create new Trainer" +
            Environment.NewLine + "2. Create new Questions" +
            Environment.NewLine + "3. Start the validation" +
            Environment.NewLine + "4. Show each Trainers" +
            Environment.NewLine + "5. Show each Questions" +
            Environment.NewLine);

            //Ligne etoile
            LineStarsBlue();

            //Faire un choix
            Console.WriteLine(Environment.NewLine + 
            "Make your choice: type 1,2, ... or 5 for exit" + Environment.NewLine);

            //Ligne etoile
            LineStarsBlue();

            //Après le choix
            int choice = 0;
            choice = int.Parse(Console.ReadLine());

            //Create a new trainer
            if (choice == 1)
            {
                //ID
                Console.WriteLine("Tappez l'ID du nouveau trainer :");
                int id = int.Parse(Console.ReadLine());
                //Création de l'adresse mail.
                string email = id + "@supinfo.com";
                Console.WriteLine(email);

                //NAME
                Console.WriteLine("OK ! Maintenant tappez le nom du nouveau trainer :");
                string name = Console.ReadLine();

                //FIRSTNAME
                Console.WriteLine("OK ! Maintenant tappez le prénom du nouveau trainer :");
                string firstname = Console.ReadLine();

                //PROMOTIONFUT
                Console.WriteLine("OK ! Maintenant tappez la promotion de validation du nouveau trainer :");
                string promotionfut = Console.ReadLine();

                //PROMOTIONCUR
                Console.WriteLine("OK ! Maintenant tappez la promotion actuelle du nouveau trainer :");
                string promotioncur = Console.ReadLine();

                //CAMPUS
                Console.WriteLine("OK ! Maintenant tappez le campus du nouveau trainer :");
                string campus = Console.ReadLine(); 

                //COURSESWT
                Console.WriteLine("OK ! Maintenant combien de matières peut enseigner ?");
                int i = int.Parse(Console.ReadLine());
                int j = 0;
                string courseswt;
                while(j<i){
                    Console.WriteLine("Quelle est le cours numéro " + j+1 + " :");
                    string courseswt = Console.ReadLine();
                    //ENVOYER L' UPDATE à la base de données
                    j++;
                }

                //COURSESAT
                Console.WriteLine("OK ! Maintenant combien de matières a-t-il déjà enseigner ?");
                int k = int.Parse(Console.ReadLine());
                int l = 0;
                string coursesat;
                while (l < k)
                {
                    Console.WriteLine("Quelle est le cours numéro " + j + 1 + " :");
                    string coursesat = Console.ReadLine();
                    //ENVOYER L' UPDATE à la base de données
                    j++;
                }
            }
            

           


           

        }

        //Methode ligne blanche
        static void WriteFullLineWhite(string value)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth));
            Console.ResetColor();
        }

        //Methode Ligne étoile fond bleu
        static void LineStarsBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************");
            Console.ResetColor();
        }
    }
}
