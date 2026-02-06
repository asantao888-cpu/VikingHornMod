using System;

namespace VikingHornMod
{
    public class VikingHorn
    {
        public void BlowHorn()
        {
            Console.WriteLine("The Viking horn sounds! Let the battle begin!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            VikingHorn horn = new VikingHorn();
            horn.BlowHorn();
        }
    }
}