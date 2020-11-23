using System;

namespace OPSuperHeroes
{
    class Program
    {
        class player
        {
            string name;
            int hp;

            //constructor
            public player (string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(3000, 3000);
                
            }
            public void SayHello()
            {
                Console.WriteLine($"{name} HELLO DONKEY!!!");
            }
            public void ShowYourHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }
            public int Damage()
            {
                Random rnd = new Random();
                return rnd.Next(100, 510);
            }
            public void damage(int Damage)
            {
                if(hp <= 0)
                {
                    hp = 0;

                }else
                {
                    hp = hp - Damage;
                }
            }
            public int HP
            {
                get { return hp; }
            }



        }   
       

        
        static void Main(string[] args)
        {
           

            Console.WriteLine("Name your character: ");
            string characterNameOne = Console.ReadLine();
            Console.WriteLine("Name your second character: ");
            string characterNameTwo = Console.ReadLine();

            player playerOne = new player(characterNameOne);
            player playerTwo = new player(characterNameTwo);
            playerOne.SayHello();
            playerOne.ShowYourHP();
            playerTwo.SayHello();
            playerTwo.ShowYourHP();

            for(int i = 0; i < 3; i++)
            {
                playerOne.damage(playerTwo.Damage());
                playerTwo.damage(playerOne.Damage());
                playerOne.ShowYourHP();
                playerTwo.ShowYourHP();
            }
            if(playerOne.HP > playerTwo.HP)
            {
                Console.WriteLine(" ''NICE SHOT M8'' ,  player one");

            }else if(playerOne.HP < playerTwo.HP)
            {
                Console.WriteLine(" ''GOOD ONE'', player Two");
            }else
            {
                Console.WriteLine("BORING tie");
            }
           
            //Console.WriteLine($"Player one did {playerOne.Damage()} damage");
        }
    }
