using GameZork.Services.Dto;
using GameZork.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.GameParts
{
    public class Fight
    {
        private MonsterService MonsterService { get; set; }
        private MonsterDto Monster { get; set; }

        private bool EndFight { get; set; } = false;
        public Fight(MonsterService monsterService)
        {
            MonsterService = monsterService;
        }

        public void Start()
        {
            var monster = MonsterService.GetRandom();
            Monster = monster;
            Console.Clear();
            Console.WriteLine($"Tu te fais agressé par {Monster.Name} !");
            while (true)
            {
                PlayerTurn();
                if (Monster.HP <= 0 || EndFight)
                    break;

                MonsterTurn();
                if (Globals.Player.HP <= 0)
                {
                    GameOver();
                    break;
                }
            }
        }

        private void GameOver()
        {
            Console.WriteLine("Tu es mort !");
            Console.WriteLine("GameOver");
            Globals.Exit.Invoke(this, null);
        }

        private void PlayerTurn()
        {
            Console.WriteLine("Que veux tu faire ?");

            int actionNumber = 0;
            var listArme = new Dictionary<int, WeaponDto>();
            foreach (var weapon in Globals.Player.Weapons)
            {
                actionNumber++;
                listArme.Add(actionNumber, weapon);
                Console.WriteLine($"{actionNumber}- Attaquer avec {weapon.Name}");
            }

            Console.WriteLine($"{actionNumber += 1}- Utiliser un object de l'inventaire");
            Console.WriteLine($"{actionNumber += 1}- Run");
            var res = Console.ReadLine();

            int.TryParse(res, out int valueSelected);

            while (valueSelected == 0)
            {
                Console.WriteLine("Soit plus clair dans ta décision !");
                res = Console.ReadLine();
                int.TryParse(res, out valueSelected);
            }
            bool actionDone = false;
            while (!actionDone)
            {
                if (valueSelected == actionNumber)
                {
                    Run();
                    actionDone = true;
                }
                else if (valueSelected == actionNumber - 1)
                {
                    if (InventoryItem())
                        actionDone = true;
                }
                else
                {
                    var weapon = listArme.GetValueOrDefault(valueSelected);
                    if (Attack(weapon ?? listArme.FirstOrDefault().Value, Monster))
                        Victory();

                    actionDone = true;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>False si exit choose </returns>
        private bool InventoryItem()
        {
            Console.WriteLine("Quel objet veux-tu utiliser ?");
            int actionNumber = 0;
            var listItem = new Dictionary<int, ItemDto>();
            foreach (var item in Globals.Player.Items)
            {
                actionNumber++;
                listItem.Add(actionNumber, item);
                Console.WriteLine($"{actionNumber}- Utiliser {item.Name}");
            }
            Console.WriteLine($"{actionNumber}- Annuler");
            var res = Console.ReadLine();

            int.TryParse(res, out int valueSelected);

            while (valueSelected == 0)
            {
                Console.WriteLine("Soit plus clair dans ta décision !");
                res = Console.ReadLine();
                int.TryParse(res, out valueSelected);
            }

            //exit
            if (valueSelected == actionNumber)
                return false;

            var itemUse = listItem.GetValueOrDefault(valueSelected);


            Globals.Player.Defense = itemUse.DefenseBoost ?? 0;
            Globals.Player.Power = itemUse.AttackBoost ?? 0;
            Globals.Player.HP = itemUse.HpRestoreValue ?? 0;
            Globals.Player.Items.Remove(itemUse);

            Console.WriteLine($"Vous avez utilisé {itemUse.Name} et regagnez {itemUse.HpRestoreValue} ainsi {itemUse.AttackBoost} d'attaque et {itemUse.DefenseBoost} de défense définitivement !");
            return true;
        }

        private void Run()
        {
            var res = new Random().Next(5);
            if (res == 3)
            {
                Console.WriteLine("Vous avez réussi à vous échapper ! (Appuye sur Entrer pour continuer)");
                Console.ReadLine();
                EndFight = true;
            }
            else
            {
                Console.WriteLine("L'évasion a échouée");
            }
        }

        private void Victory()
        {
            var xp = new Random().Next(100, 800);
            Globals.Player.XP += xp;
            Console.WriteLine($"Victoire tu as vaincu la créature et tu as gagné {xp} XP!");

            if (Globals.Player.XP > Globals.Player.NextLevelXpRequired)
            {
                Globals.Player.Level++;
                Globals.Player.XP -= Globals.Player.NextLevelXpRequired;

                Globals.Player.MaxHP += 10;
                Globals.Player.HP = Globals.Player.MaxHP;
                Console.WriteLine($"Tu es passé niveau {Globals.Player.Level} ! Tu as gagné 10HP et es maintenant en pleine forme !");
            }
            Console.WriteLine("Appuye sur Entrer pour continuer");
            Console.ReadLine();
        }

        private void MonsterTurn()
        {
            var dmg = Monster.Power - Globals.Player.Defense > 0 ? Monster.Power - Globals.Player.Defense : 0;
            Globals.Player.HP -= dmg;
            Console.WriteLine($"Aïe ! Tu viens de subir {dmg} dégats suite à son attaque!");
        }

        /// <summary>
        /// Attack a monster
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="target"></param>
        /// <returns>true if the attack kill, false if not </returns>
        private bool Attack(WeaponDto weapon, FighterDto target)
        {
            if (weapon == null || target == null)
                return false;

            var dmg = (weapon.Damage - target.Defense) > 0 ? weapon.Damage - target.Defense : 0;
            target.HP -= dmg;
            Console.WriteLine($"Tu attaques avec {weapon.Name} et infliges {dmg} dégats au monstre !");
            if (target.HP > 0)
                return false;
            else
            {
                Console.WriteLine($"Il lui reste {Monster.HP} !");
                return true;
            }
        }
    }
}
