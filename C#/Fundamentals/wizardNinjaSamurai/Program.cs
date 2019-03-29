using System;

namespace WizardNinjaSamari
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard MyWizard = new Wizard("Dumbledore");
            Ninja MyNinja = new Ninja("Jackie Chan");
            Samaurai MySamauri = new Samaurai("Wang");
            Console.WriteLine($"{MyWizard.Name}'s health is: {MyWizard.Health}");
            Console.WriteLine($"{MyNinja.Name}'s health is: {MyNinja.Health}");
            Console.WriteLine($"{MySamauri.Name}'s health is: {MySamauri.Health}");
            Console.WriteLine("****************************************************");
            MyWizard.Attack(MyNinja);
            Console.WriteLine($"{MyWizard.Name} ATTACKED {MyNinja.Name}");
            Console.WriteLine("****************************************************");
            MyWizard.Attack(MySamauri);
            Console.WriteLine($"{MyWizard.Name} ATTACKED {MySamauri.Name}");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"{MyWizard.Name}'s health is now: {MyWizard.Health}");
            Console.WriteLine($"{MyNinja.Name}'s health is now: {MyNinja.Health}");
            Console.WriteLine($"{MySamauri.Name}'s health is now: {MySamauri.Health}");
            Console.WriteLine("****************************************************");
            MySamauri.Attack(MyWizard);
            Console.WriteLine($"{MySamauri.Name} ATTACKED {MyWizard.Name}");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"{MyWizard.Name}'s health is now: {MyWizard.Health}");
            Console.WriteLine($"{MyNinja.Name}'s health is now: {MyNinja.Health}");
            Console.WriteLine($"{MySamauri.Name}'s health is now: {MySamauri.Health}");
            Console.WriteLine("****************************************************");
            MySamauri.Attack(MyWizard);
            Console.WriteLine($"{MySamauri.Name} ATTACKED {MyWizard.Name}");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"{MyWizard.Name}'s health is now: {MyWizard.Health}");
            Console.WriteLine($"{MyNinja.Name}'s health is now: {MyNinja.Health}");
            Console.WriteLine($"{MySamauri.Name}'s health is now: {MySamauri.Health}");
            Console.WriteLine("****************************************************");
            MyWizard.Heal(MyNinja);
            Console.WriteLine($"{MyWizard.Name} HEALED {MyNinja.Name}");
            Console.WriteLine("****************************************************");
            MyWizard.Heal(MySamauri);
            Console.WriteLine($"{MyWizard.Name} HEALED {MySamauri.Name}");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"{MyWizard.Name}'s health is now: {MyWizard.Health}");
            Console.WriteLine($"{MyNinja.Name}'s health is now: {MyNinja.Health}");
            Console.WriteLine($"{MySamauri.Name}'s health is now: {MySamauri.Health}");
            Console.WriteLine("****************************************************");

        }
    }
}
