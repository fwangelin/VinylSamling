using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication10
{
    class ApplicationEngine
    {


        public static void ExitApplication()
       {
            Console.WriteLine("Goodbye");
            Console.Clear();
            Environment.Exit(0);
       }

        public static void ChoiceToEditOrRemoveAlbumFromList()
        {
            Console.Clear();
            Console.WriteLine("Choose 1. if you want to EDIT album.\nChoose 2. if you want to DELETE album.");

            string inputChoiceForDeletingOrEditingAlbums = Console.ReadLine();

            switch (inputChoiceForDeletingOrEditingAlbums)
            {
                case "1": EditAlbumFromList(); break;
                case "2": RemoveAlbumFromList(); break;
                default:
                    Console.WriteLine("Wrong choice buddy, I'll just go ahead and send you to main menu since you can't read...");
                    Console.Read();
                    MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;

            }



        }

        public static void RemoveAlbumFromList()
        {
            Console.Clear();
            VinylRecords.ReadAlbumsFromFile();
            Console.WriteLine("What album do you choose to remove?");
            Console.Read();

        }

        public static void EditAlbumFromList()
        {
            Console.Clear();
            VinylRecords.ReadAlbumsFromFile();
            Console.WriteLine("What album do you choose to edit?");
            Console.Read();

        }
    }
}
