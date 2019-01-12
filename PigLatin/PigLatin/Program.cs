using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            string text = "Astazi, e - ziua. -/   mea., zi/ - // frumoasa .,ca - ,.mineeee!";
            PigLatin test = new PigLatin(text);
            Console.WriteLine(text);
            test.Modify();

            Console.WriteLine("Enter your text: ");
            string text2 = Console.ReadLine();
            PigLatin test2 = new PigLatin(text2);
            test2.Modify();

        }
    }
}
