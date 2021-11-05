using System;

namespace Inventory_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if everything works
            Weapon saber = new Weapon();
            Armor kingsCrown = new Armor();
            saber.Equip();
            kingsCrown.Equip();
        }
    }

    // Abstract base class for Armor and Weapon
    abstract class Equiment
    {
        public virtual void Equip()
        {
            Console.WriteLine("Equiped");
        }
    }

    // inherited class
    class Armor : Equiment
    {
        // overrides the base class its function
        public override void Equip()
        {
            Console.WriteLine("Equiped");
            Console.WriteLine("Boost stats and update on character visuals");
            Console.WriteLine("consumed armor slot");
        }
    }

    class Weapon : Equiment
    {
        // overrides the base class its function
        public override void Equip()
        {
            Console.WriteLine("Equiped");
            Console.WriteLine("Boost stats and update on character visuals");
            Console.WriteLine("consumed weapon slot");
        }
    }
}
