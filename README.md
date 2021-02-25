# GameZork
Lancer le projet :
 - Saisir l'adresse de votre BDD dans le fichier appsettings.json dans Server=votre_serveur, 
ainsi que le nom que votre BDD dans Database=votre_BDD
dans la chaine de caractère "myDb1"

Au niveau de GameZork/GameZork.DataAccessLayer, lance "dotnet ef database update" dans un terminal 

tu peux ensuite exécuter la solution dans visual studio directement 

Explication Bonus :

Easter Egg : Tapes 'pink' dans le terminal et un vieil ami viendra vous rendre visite ! (Accessible dès que la saisie est disponible) 


Explication manque de persistence des données :

Je ne peux en effet pas sauvegarder la partie en base, car il y avait des conflits dans les ID lors de l'UPDATE dans la BDD, 
et je n'ai pas su trouver la raison de ces erreurs.
J'ai donc prit la décision de ne pas pouvoir sauvegarder les informations de la partie pour pouvoir quand même jouer au jeu convenablement.
Etant tout seul sur le projet, je n'ai pas eu le temps d'approfondir la question pour trouver la solution. 
Ainsi, lors du menu principale si l'on sélectionne l'option 2, une partie est créé au lieu d'être chargé.

Il est cependant bien possible de récupérer les données en base qui sont généré via les Seeder.

Sinon l'ensemble des fonctionnalités sont présentes ! Enjoy ;)
