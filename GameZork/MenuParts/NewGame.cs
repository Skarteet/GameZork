using GameZork.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.MenuParts
{
    public class NewGame
    {
        private readonly PlayerService PlayerService;
        public NewGame(PlayerService playerService)
        {
            this.PlayerService = playerService;
        }

        public void CreateGame()
        {
            Console.Clear();
            Console.WriteLine("Quel est ton nom jeune aventurier ?");
            var name = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Tu dois me donner ton nom !");
                name = Console.ReadLine();
            }

            Globals.Player = PlayerService.CreatePlayer(name);
        }
    }
}
