using System;

namespace StarPatternA_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the A-Z Star Pattern Program!!!");
            StarPattern pattern = new StarPattern();
            pattern.Apattern();
            pattern.Cpattern();
            pattern.Dpattern();
            pattern.Epattern();
        }
    }
}
