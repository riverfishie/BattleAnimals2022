using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleAnimalsImproved
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int poopyHealth, bebeHealth, money;

            money = 200;
            int wins = 0;

            string bet = "";

            int amount = 0;





            bebeHealth = 10;
            poopyHealth = 10;
            int damage;
            int b = 0;
            int p = 0;


            while (b != 10 && p != 10)
            {

                while (poopyHealth != 0 && bebeHealth != 0)
                {


                    if (poopyHealth == 10 && bebeHealth == 10)
                    {

                        Console.WriteLine(b + " Times Bebe won");
                        Console.WriteLine(p + " Times Poppy won");
                        Console.WriteLine(wins + " Times you have won the bet");
                        //betting needs to happen before game
                        Console.WriteLine("Who do you bet on ?");
                        bet = Console.ReadLine();

                        while (bet != "b" && bet != "B" && bet != "p" && bet != "P")
                        {
                            Console.WriteLine("Pls input (B)ebe or (P)oppy...");
                            bet = Console.ReadLine();
                        }

                        Console.WriteLine("How much do you want to bet ?");
                        Console.WriteLine("£" + money + " total");
                        amount = int.Parse(Console.ReadLine());
                        money = money - amount;


                        Console.ReadLine();
                    }

                    damage = rnd.Next(1, 6);
                    Console.WriteLine("Bebe took " + damage + " damage !");
                    Console.ReadLine();
                    bebeHealth -= damage;

                    damage = rnd.Next(1, 6);
                    Console.WriteLine("Poppy took " + damage + " damage !");
                    Console.ReadLine();
                    poopyHealth -= damage;

                    if (poopyHealth <= 0)
                    {
                        poopyHealth = 0;
                    }
                    if (bebeHealth <= 0)                                            // using random class
                    {
                        bebeHealth = 0;
                    }

                    Console.WriteLine("Bebe health : " + bebeHealth + "/10");
                    Console.WriteLine("Poppy health : " + poopyHealth + "/10");

                    Console.ReadLine();

                    if (bebeHealth != 0 && poopyHealth == 0)
                    {
                        Console.WriteLine("Beeby win");
                        if (bet == "B" || bet == "b")
                        {
                            money += (amount * 2);
                            Console.WriteLine("You won the bet! £" + amount * 2);
                            wins++;
                        }
                        else if (bet == "p" || bet == "P")
                        {
                            Console.WriteLine("aww you lost the bet...");
                        }
                        b++;
                        bebeHealth = 10;
                        poopyHealth = 10;
                        Console.ReadLine();
                        Console.Clear();

                    }
                    if (poopyHealth != 0 && bebeHealth == 0)
                    {
                        Console.WriteLine("Poopy win");
                        if (bet == "p" || bet == "P")
                        {

                            money += (amount * 2);
                            Console.WriteLine("You won the bet! £" + amount * 2 );
                            wins++;
                        }
                        else if (bet == "b" || bet == "B")
                        {
                            Console.WriteLine("aww you lost the bet...");
                        }
                        p++;
                        bebeHealth = 10;
                        poopyHealth = 10;
                        Console.ReadLine();
                        Console.Clear();

                    }
                    if (poopyHealth == 0 && bebeHealth == 0)
                    {
                        Console.WriteLine("Both fainted!");
                        bebeHealth = 10;
                        poopyHealth = 10;
                        money += amount;
                        Console.ReadLine();
                        Console.Clear();

                    }


                }

            }
            Console.ReadLine();
        }
    }
}
