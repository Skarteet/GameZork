using GameZork.GameParts;
using GameZork.Services.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameZork.MenuParts
{
    public class NewGame
    {
        private readonly PlayerService PlayerService;
        private static TurnAction TurnActionView { get; set; }
        public NewGame(PlayerService playerService)
        {
            this.PlayerService = playerService;
        }

        public void CreateGame()
        {
            Console.Clear();
            Console.WriteLine("Quel est ton nom jeune aventurier ?");
            var name = ZorkRead.ReadLine();

            while(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Tu dois me donner ton nom !");
                name = ZorkRead.ReadLine();
            }

            Globals.Player = PlayerService.CreatePlayer(name);
            TurnActionView = Globals.Services.GetService<TurnAction>();
            Console.Clear();
            TurnActionView.TurnActionChoice();
        }
    }
}
