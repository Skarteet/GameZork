using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameZork.MenuParts
{
    public class Menu
    {
        public EventHandler Exit { get; set; }
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
            var key = Console.ReadKey();


            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    NewGameView = Globals.Services.GetService<NewGame>();
                    NewGameView.CreateGame();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    About.BackToMenu += (o, e) => Start();
                    About.AboutView();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Exit.Invoke(this, null);
                    break;
                default:
                    Start();
                    break;
            }
        }
    }
}
