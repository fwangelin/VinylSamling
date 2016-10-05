using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication10
{
    class VinylRecords
    {
       
        public static List<string> inputAlbums = new List<string>();
        public static string[] textFileArrayForSavingAlbums;

        

        public static void ReadAlbumsFromFile()
        {
            //inputAlbums.Clear();
            textFileArrayForSavingAlbums = File.ReadAllLines(@"C:\Users\Fredrik\VinylSamlingar.txt");

            foreach (string item in textFileArrayForSavingAlbums)
            {
                inputAlbums.Add(item);
            }
        }

        public static void DisplayExistingVinylsAsListArray()
        {
            Console.Clear();
            Console.WriteLine("Below is your collection. It is displayed in order: Album name, Artist, Genre, Year of release");
            Console.WriteLine("********************************************************************************************************");

            ReadAlbumsFromFile();

            foreach (string item in textFileArrayForSavingAlbums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("\n Awsome Collection! \n \n Choose 1 if you want to add a new album \n Choose 2 if you want to go back to main menu.");
            Console.WriteLine();

            string inputChoiceToAddNewAlbum = Console.ReadLine();

            switch (inputChoiceToAddNewAlbum)
            {
                case "1": LetUserKnowWhatTheyNeedToInput(); break;
                case "2": MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;
                default:
                    Console.WriteLine("Wrong choice buddy, I'll just go ahead and send you to main menu since you can't read...");
                    Console.Read();
                    MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;


            }


        }

        public static void LetUserKnowWhatTheyNeedToInput()
        {
            Console.Clear();
            Console.WriteLine("Input Album Name:");
            string inputAlbumNameForNewAlbum = Console.ReadLine();
            Console.WriteLine("Input Artist name:");
            string inputArtistNameForNewAlbum = Console.ReadLine();
            Console.WriteLine("What's the fucking Genre?:");
            string inputGenreForNewAlbum = Console.ReadLine();
            Console.WriteLine("Let me know the year it was released:");
            string inputRealeseYearForNewAlbum = Console.ReadLine();

            
            string fileContent =
                inputAlbumNameForNewAlbum + ", " + inputArtistNameForNewAlbum + ", " + inputGenreForNewAlbum + ", " + inputRealeseYearForNewAlbum + Environment.NewLine;

            inputAlbums.Add(fileContent);

            File.WriteAllLines(@"C:\Users\Fredrik\VinylSamlingar.txt", inputAlbums);
            
            Console.WriteLine("\n Sweet! I fucking love that album, now what do you wanna do? \n \n Choose 1 if you want to add a new album. \n Choose 2 if you want to go back to main menu. \n Choose 3 if you want to see your Collection");
            

            string inputChoiceToAddNewAlbum = Console.ReadLine();

            switch (inputChoiceToAddNewAlbum)
            {
                case "1": LetUserKnowWhatTheyNeedToInput(); break;
                case "2": MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;
                case "3": DisplayExistingVinylsAsListArray(); break;
                default:

                    Console.WriteLine("Wrong choice buddy, I'll just go ahead and send you to main menu since you can't read...");
                    Console.Read();
                    MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;


            }
          



        }


       

        

        


           
    }
}
