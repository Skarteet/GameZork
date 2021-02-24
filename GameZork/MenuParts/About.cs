using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.MenuParts
{
    public static class About
    {
        public static EventHandler BackToMenu { get; set; }
        public static void AboutView()
        {
            Console.Clear();
            Console.WriteLine("Edité par LEBLANC Antoine");
            Console.WriteLine();
            Console.WriteLine("1 : Retourner au menu principal");

            var res = ZorkRead.ReadLine();
            switch (res)
            {
                case "1":
                    BackToMenu.Invoke(null, null);
                    break;
                default:
                    AboutView();
                    break;
            }

        }
    }
}
