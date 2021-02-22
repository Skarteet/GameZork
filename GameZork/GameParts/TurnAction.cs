using GameZork.Services.Dto;
using GameZork.Services.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GameZork.GameParts
{
    public class TurnAction
    {
        private PlayerService PlayerService { get; set; }
        private CellService CellService { get; set; }
        private Fight Fight { get; set; }
        public TurnAction(PlayerService playerService, CellService cellService)
        {
            PlayerService = playerService;
            CellService = cellService;
            Fight = Globals.Services.GetService<Fight>();
        }

        public void TurnActionChoice()
        {
            Console.WriteLine("Que veux-tu faire ?");
            Console.WriteLine("1 : Afficher l'inventaire");
            Console.WriteLine("2 : Afficher les caractéristiques");
            Console.WriteLine("3 : Se déplacer");
            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Inventory();
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Stats();
                    Console.Clear();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Move();
                    Console.Clear();
                    break;
                default:
                    break;

            }

            TurnActionChoice();
        }
        private static void Inventory()
        {
            Console.Clear();
            Console.WriteLine("Objets : ");
            if (Globals.Player.Items != null && Globals.Player.Items.Any())
            {
                foreach (var item in Globals.Player.Items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Armes : ");
            if (Globals.Player.Weapons != null && Globals.Player.Weapons.Any())
            {
                foreach (var weapon in Globals.Player.Weapons)
                {
                    Console.WriteLine(weapon.ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ranger son sac ? (Tape \"Ranger\")");

            string line = string.Empty;
            while (line.ToLowerInvariant() != "ranger")
            {
                line = Console.ReadLine();
            }
        }

        private static void Stats()
        {
            Console.Clear();
            Console.WriteLine("Caractéristiques : ");
            Console.WriteLine($"Vie actuelle : {Globals.Player.HP} PV");
            Console.WriteLine($"Vie maximum : {Globals.Player.MaxHP} PV");
            Console.WriteLine($"Niveau : {Globals.Player.Level}");
            Console.WriteLine($"Expérience : {Globals.Player.XP} XP");
            Console.WriteLine($"Expérience requise pour le niveau suivant : {Globals.Player.NextLevelXpRequired} XP");
            Console.WriteLine($"Puissance : {Globals.Player.Power}");
            Console.WriteLine($"Défense: {Globals.Player.Defense}");
            Console.WriteLine();

            Console.WriteLine("Reprendre ses esprits ? (Tape \"Reveil\")");

            string line = string.Empty;
            while (line.ToLowerInvariant() != "reveil")
            {
                line = Console.ReadLine();
            }
        }

        private void Move()
        {
            Console.Clear();
            Console.WriteLine("Vers où souhaites-tu t'aventurer ? (Tape Est,Nord,Ouest,Sud)");
            string line = Console.ReadLine().ToLowerInvariant();
            while (line != "est" && line != "nord" && line != "sud" && line != "ouest")
            {
                Console.WriteLine("Exprime toi plus clairement ! (Tape Est,Nord,Ouest,Sud)");
                line = Console.ReadLine();
            }

            var cell = Globals.Player.Cell;
            CellDto nextCell = null;
            bool move = false;

            while (!move)
            {
                switch (line)
                {
                    case "est":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX + 1 && c.PosY == cell.PosY);
                        break;
                    case "nord":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX && c.PosY == cell.PosY + 1);
                        break;
                    case "sud":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX - 1 && c.PosY == cell.PosY);
                        break;
                    case "ouest":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX && c.PosY == cell.PosY - 1);
                        break;
                }

                if (nextCell == null)
                {
                    Console.WriteLine("Les montagnes géantes bloque ton avancée. Tu dois choisir une autre direction !");
                    line = Console.ReadLine();
                }
                else
                    move = true;
            }

            Globals.Player.Cell = nextCell;
            //PlayerService.Save(Globals.Player);

            MovementRandomMeeting();
        }

        private void MovementRandomMeeting()
        {
            var random = new Random().Next(1, 100);

            //Fight
            if (Enumerable.Range(1, 30).Contains(random))
            {
                Fight.Start();
            }
            //Item
            else if (Enumerable.Range(31, 60).Contains(random))
            {

            }
            //Nothing
            else
            {
                Nothing();
            }
        }

        private static void Nothing()
        {
            Console.Clear();
            Console.WriteLine("Tu est bien arrivé à destination sans encombres ! ");
            Console.WriteLine();

        }

    }
}
