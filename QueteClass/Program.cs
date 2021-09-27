using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Character joueur1 = new Character();
            joueur1.PV = 50000 ;
            joueur1.name = "David";
            joueur1.attaque = 2500;
            joueur1.defense = 10;

            Character joueur2 = new Character();
            joueur2.PV = 50000;
            joueur2.name = "Goliat";
            joueur2.attaque = 100;
            joueur2.defense = 500;

            int i = 0;

            Console.ReadLine();
            while (joueur1.IsAlive() && joueur2.IsAlive())
            {
                i += 1;
                joueur1.Attack(joueur2);
                joueur2.Attack(joueur1);

                Console.WriteLine("Tour " + i +" :");
                Console.WriteLine(joueur2.name + " attaque " + joueur1.name);
                Console.WriteLine(joueur1.name + " attaque " + joueur2.name);
                Console.WriteLine("PV restant : ");
                Console.WriteLine(joueur1.name + " : " + joueur1.PV );
                Console.WriteLine(joueur2.name + " : " + joueur2.PV);

                Console.ReadLine();

            }

        }
    }




    class Character
    {
        public string name;
        public int PV;
        public int attaque;
        public int defense;


        public bool IsAlive()
        {
            if (PV > 0)
                return true;
            else return false;
        }

        public int Attack(Character Anothercharacter)
        {
            int degat = Anothercharacter.attaque - defense;
            if (degat > PV)
                return PV = 0;
            else if (degat < 0)
                return PV;
            else
                return PV  -= degat; 
        }
        

    }
}
