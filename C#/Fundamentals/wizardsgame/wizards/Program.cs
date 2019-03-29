using System;

namespace wizards
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard bob = new Wizard("Bob");
            Ninja bill = new Ninja("Bill");
            Samurai jack = new Samurai("Jack");
            Zombie fred = new Zombie("Fred");
            Zombie george = new Zombie("George");
            Spider bah = new Spider("Bahamut");
            Console.WriteLine("Your party consists of bob the Wizard, bill the Ninja, and Samurai jack.");
            Console.WriteLine($"You are fighting 2 zombies, Fred and George, and a spider named Bahamut.");
            Console.WriteLine("");
            while(fred.health > 0 && george.health > 0 && bah.health > 0)
            {
                Console.WriteLine("---------------HERO TURN------------------");
                Console.WriteLine("");
                Console.WriteLine("The Wizard attacks first.");
                Console.WriteLine("Do you want to attack or heal?");
                string move = Console.ReadLine();
                if(move == "heal")
                {
                    Console.WriteLine("Who do you want to heal yourself (me), Jack, or Bill?");
                    string heal_target = Console.ReadLine();
                    if(heal_target == "me")
                    {
                        bob.Heal(bob);
                    }
                    if(heal_target == "Jack")
                    {
                        bob.Heal(jack);
                    }
                    if(heal_target == "Bill")
                    {
                        bob.Heal(bill);
                    }
                }
                if(move == "attack")
                {
                    Console.WriteLine("Which enemy do you want to attack, Fred, George, or Bahamut?");
                    string attack_target = Console.ReadLine();
                    if(attack_target == "Fred")
                    {
                        bob.Attack(fred);
                    }
                    
                    if(attack_target == "George")
                    {
                        bob.Attack(george);
                    }
                    if(attack_target == "Bahamut")
                    {
                        bob.Attack(bah);
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("##########################################");
                Console.WriteLine("");
                Console.WriteLine("The Ninja attacks next.");
                Console.WriteLine("Do you want to attack or steal?");
                move = Console.ReadLine();
                if(move == "steal")
                {
                    Console.WriteLine("Who do you want to steal from? Fred, George, or Bahamut?");
                    string steal_target = Console.ReadLine();
                    if(steal_target == "Fred")
                    {
                        bill.Steal(fred);
                    }
                    if(steal_target == "George")
                    {
                        bill.Steal(george);
                    }
                    if(steal_target == "Bahamut")
                    {
                        bill.Steal(bah);
                    }
                }
                if(move == "attack")
                {
                    Console.WriteLine("Which enemy do you want to attack, Fred, George, or Bahamut?");
                    string attack_target = Console.ReadLine();
                    if(attack_target == "Fred")
                    {
                        bill.Attack(fred);
                    }
                    
                    if(attack_target == "George")
                    {
                        bill.Attack(george);
                    }
                    if(attack_target == "Bahamut")
                    {
                        bill.Attack(bah);
                    }
                    
                }
                Console.WriteLine("");
                Console.WriteLine("##########################################");
                Console.WriteLine("");
                Console.WriteLine("The Samurai attacks next.");
                Console.WriteLine("Do you want to attack or meditate?");
                move = Console.ReadLine();
                if(move == "meditate")
                {
                    jack.Meditate();
                }
                if(move == "attack")
                {
                    Console.WriteLine("Which enemy do you want to attack, Fred, George, or Bahamut?");
                    string attack_target = Console.ReadLine();
                    if(attack_target == "Fred")
                    {
                        jack.Attack(fred);
                    }
                    
                    if(attack_target == "George")
                    {
                        jack.Attack(george);
                    }
                    if(attack_target == "Bahamut")
                    {
                        jack.Attack(bah);
                    }
                    
                }
                Console.WriteLine("");
                Console.WriteLine("---------------ENEMY TURN------------------");
                Console.WriteLine("");
                Random rand = new Random();
                if(fred.health > 0)
                {
                    int fred_target = rand.Next(3);
                    if(fred_target == 0)
                    {
                        fred.Attack(bob);
                    }
                    if(fred_target == 1)
                    {
                        fred.Attack(bill);
                    }
                    if(fred_target == 2)
                    {
                        fred.Attack(jack);
                    }
                }
                if(george.health > 0)
                {
                    int george_target = rand.Next(3);
                    if(george_target == 0)
                    {
                        george.Attack(bob);
                    }
                    if(george_target == 1)
                    {
                        george.Attack(bill);
                    }
                    if(george_target == 2)
                    {
                        george.Attack(jack);
                    }
                }
                if(bah.health > 0)
                {
                    int bah_target = rand.Next(3);
                    if(bah_target == 0)
                    {
                        bah.Attack(bob);
                    }
                    if(bah_target == 1)
                    {
                        bah.Attack(bill);
                    }
                    if(bah_target == 2)
                    {
                        bah.Attack(jack);
                    }
                }
            }
            Console.WriteLine("GAME OVER!");
        }
    }
}