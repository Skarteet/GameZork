using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameZork.MenuParts
{
    public class Menu
    {
        private static NewGame NewGameView { get; set; }
        public Menu()
        {

        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("################################");
            Console.WriteLine("##      VALHALLA'S QUEST      ##");
            Console.WriteLine("################################");
            Console.WriteLine("MAIN MENU :");
            Console.WriteLine("1 : Create New Game");
            Console.WriteLine("2 : Load Saved Game");
            Console.WriteLine("3 : About Game");
            Console.WriteLine("4 : Exit");
            var res = ZorkRead.ReadLine();


            switch (res)
            {
                case "1":
                    NewGameView = Globals.Services.GetService<NewGame>();
                    NewGameView.CreateGame();
                    break;
                case "2":
                    //TODO: A changer une fois la BDD implémenté
                    NewGameView = Globals.Services.GetService<NewGame>();
                    NewGameView.CreateGame();
                    break;
                case "3":
                    About.BackToMenu += (o, e) => Start();
                    About.AboutView();
                    break;
                case "4":
                    Globals.Exit.Invoke(this, null);
                    break;
                default:
                    Start();
                    break;
            }
        }
    }
}
