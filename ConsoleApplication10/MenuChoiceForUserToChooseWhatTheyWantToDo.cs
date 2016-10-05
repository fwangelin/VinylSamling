using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class MenuChoiceForUserToChooseWhatTheyWantToDo
    {
        

        public static void ChooseAlternativeInStartMenuGraphics()
        {
            GraphicsForUserMoreLikelyToUseTheProgramOften.StartApplicationScreenColors();
            GraphicsForUserMoreLikelyToUseTheProgramOften.ShowStartMenuGraphics();
            string inputStartMenuChoice;
            inputStartMenuChoice = Console.ReadLine();


            switch (inputStartMenuChoice)
            {
                case "1": VinylRecords.LetUserKnowWhatTheyNeedToInput(); break;
                case "2": VinylRecords.DisplayExistingVinylsAsListArray(); break;
                case "3": ApplicationEngine.ChoiceToEditOrRemoveAlbumFromList(); break;
                case "4": ApplicationEngine.ExitApplication(); break;
                
                default:
                    MenuChoiceForUserToChooseWhatTheyWantToDo.ChooseAlternativeInStartMenuGraphics(); break;
            }
        }

    }

        

}
