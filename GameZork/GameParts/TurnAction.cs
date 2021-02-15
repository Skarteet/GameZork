using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.GameParts
{
    public class TurnAction
    {
        public TurnAction()
        {

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
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Stats();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
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
            foreach (var item in Globals.Player.Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Armes : ");
            foreach (var weapon in Globals.Player.Weapons)
            {
                Console.WriteLine(weapon.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Ranger son sac ? (Tape \"Ranger\")");

            string line = null;
            while (line != "Ranger".ToLowerInvariant())
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

            string line = null;
            while (line != "Reveil".ToLowerInvariant())
            {
                line = Console.ReadLine();
            }
        }

        private void Move()
        {
            Console.Clear();
            Console.WriteLine("Vers où souhaites-tu t'aventurer ? (Tape Est,Nord,Ouest,Sud)");
            string line = Console.ReadLine();
            while (line == "Est" || line == "Nord" || line == "Sud" || line == "Ouest")
            {
                Console.WriteLine("Exprime toi plus clairement ! (Tape Est,Nord,Ouest,Sud)");
                line = Console.ReadLine();
            }

            var cell = Globals.Player.Cell;
            CellDto nextCell = null;

            while (nextCell == null)
            {
                switch (line)
                {
                    case "Est":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX + 1 && c.PosY == cell.PosY);
                        break;
                    case "Nord":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX && c.PosY == cell.PosY + 1);
                        break;
                    case "Sud":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX - 1 && c.PosY == cell.PosY);
                        break;
                    case "Ouest":
                        nextCell = Globals.Player.Map.Cells.FirstOrDefault(c => c.PosX == cell.PosX && c.PosY == cell.PosY - 1);
                        break;
                }

                Console.WriteLine("Les montagnes géantes bloque ton avancée. Tu dois choisir une autre direction !");
                line = Console.ReadLine();
            }

            Globals.Player.Cell = nextCell;

        }

        private void MovementRandomMeeting()
        {
            var random = new Random().Next(1, 100);

            //Fight
            if (Enumerable.Range(1, 30).Contains(random))
            {

            }
            //Item
            else if (Enumerable.Range(31, 60).Contains(random))
            {

            }
            //Nothing
            else
            {

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
