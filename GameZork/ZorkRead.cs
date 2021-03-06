﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork
{
    public static class ZorkRead
    {
        public static string ReadLine()
        {
            var res = Console.ReadLine().ToLowerInvariant();
            if (res == "exit")
            {
                Globals.Exit.Invoke(null ,null);
            }
            else if (res == "pink")
            {
                Console.Write(@"                    ,;|||||\                       _________
  ___               |;|||:;:|                    ,' Tickled `----.
/;,a.\\             |||||...._                   `-. _   PINK!!!! ;
|||@@@\\\        __----,'......~\_    ,---._        ;; `-._______,'
|||@@@@\\\,-~~~~::::::,'... _.----\_,'      `.      '
|||;aaa/,;;;;:::::::::: _.-':      ;...._    ;
`::||||;;;;:::::::::::' `--'    ,;;:::::~:~~----._____
     ;;;;;::::::::::::`-.     ,;::::::::::::::::::::::::___
    |;;;;;:::::::::::::::`---;:::::::::::::::::::'.,-/~~   ~~\-._
    |;;;;;;;;::::::::::::::::::::::: :: ::::::',-'   `\  |  /'.  :
     `-:;;;;;;;;;;:::::::::::::::::::::::: :::;  . .   `\:/' . . ;
        `~--;;;;;;;;;;;;::::::::::::::::::: ::: . .      |     ,'
            `~~~~--;;;;;;;;;;;;::::::::: ::::::`..    _/' `\_/';
                   `~~.;;;;;::::::::::::::::::::::---' . ..   ,'
                       ~~;.....;'~~~`---.::::::::::         ,'
                         :;;;:::         ~~~~~~`---`-.____,'
                         `|;;::::
                          |;;:::::                   ...........
                          |;;:::::                 .::::::::::|||:.
                       ___||::::::: ___           .||||        `:|||
                     /':::`|::::::|':::`\        .||||          ||||
                    /::::::||/@@@\::::::::\      ||||           ||||
                   /::::::||:@@@@@@@\::::::\     ||||__         ||||
                  /::::::|||@@@@@@@@@|::::::\    |`.`--)        ||||
                 /::::::;||:@@@@@@@@@|:::::::\    \_~_/        ,||||
                /:::::;;|||:@@@@@@@@@@|\::::::\                ||||'
               /:::::;;;||::@@@@@@@@@@| \::::::\               ||||
              /:::::;; |||:@@@@@@@@@@@@| \::::::\              ||||.
             /:::::;;  |||:@@@@@@@@@@@@|. \::::::\             `||||
            ,'::::;;  |||::@@@@@@@@@@@@||  \::::::\___          ||||
           ,:::::;;   |||::@@@@@@@@@@@|:|   \;,'~~'_  `-.      ,||||
          ,:::::;;    ||::@@@@@@@@@@@@|:|   ,'   ~~ `._  `.   ,||||'
         ,::::;;;    |||::_--._@@@@@@|::| ,'     __    `._|  .||||'
        ,:::::;;     ;~~~'     ~--.__|::|;      '  `-.   ;   ||||'
       ,::::;;;    ,'        ::::::::~~--;__          `_,'   |||||
      ,:::::;;   ,'         (~--::::::::::: ~~-._    _;\     `|||||
     ,:::::;/  ,'   _______-.-----~~~-._ ::::::  `--' ;;\     `|||||
    |:::::/  ____.-:::::::::::::::::::,-~-.::::::::::::::)    .||||'
    |:::::`~':::::::::::::::::::.--'|::::| `~~~~~--.__.-'     ||||'
    `::::::::::::::::___----~~~~@@@@|::::|                 .|||||'
     `--____,---~~~~~   @@@@@@@@@@@|:::::|                ,||||.'
            ;          `.@@@@@@@@@@|:::::|            ,||||||.'
           |  :   :     ;@@@@@@@@@@|:::::|         ,|||||||.'
           `._;.__;`-._,'@@@@@@@@@@|:::::|      ,|||||||'~~
                  |:@@@@@@@@@@@@@@|:::::::|   ,||||||'~
                  |:@@@@@@@@@@@@@@|:::::::|  ||||||'
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                return ReadLine();
            }
            else
            {
                return res;
            }
            return null;
        }
    }
}
