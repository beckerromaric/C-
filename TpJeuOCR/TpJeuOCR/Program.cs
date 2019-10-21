using System;

namespace TpJeuOCR
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("|-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-|");
            Console.WriteLine("Bienvenue dans la chasse aux monstres !");
            Console.WriteLine("|-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-|");
            Jeu();
        }

        private static void Jeu()
        {
            Joueur romaric = new Joueur(150);

            int compteurMobFacile = 0;
            int compteurMobDifficile = 0;

            while (romaric.EstVivant)
            {
                MonstreFacile mob = FabriqueDeMob();

                while(mob.EstVivant && romaric.EstVivant)
                {
                    romaric.Attaquer(mob);

                    if (mob.EstVivant)
                    {
                        mob.Attaquer(romaric);
                    }
                }

                if (romaric.EstVivant)
                {
                    if (mob is MonstreDifficile)
                    {
                        compteurMobDifficile++;
                    }
                    else
                    {
                        compteurMobFacile++;
                    }
                }
                else
                {
                    Console.WriteLine("\nGame Over !! Vous êtes mort !");
                    break;
                }
            }
            Console.WriteLine("\nFélicitation ! Vous avez tuer {0} mobs faciles et {1} mobs difficiles. " +
                "Vous avez {2} points de vie", compteurMobFacile, compteurMobDifficile, (compteurMobDifficile + compteurMobFacile * 2));
        }

        private static MonstreFacile FabriqueDeMob()
        {
            if(random.Next(2) == 0)
            {
                return new MonstreFacile();
            }
            else
            {
                return new MonstreDifficile();
            }
        }

    }
}
