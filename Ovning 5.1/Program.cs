using System;

namespace övning_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = {
                "Det här är den första meningen.",
                "Här kommer den andra meningen.",
                "Och slutligen, den tredje meningen."
            };

            foreach (string mening in meningar)
            {
                Console.WriteLine(mening);
                Console.WriteLine(); // Lägg till en tom rad mellan varje mening
            }
        }
    }
}
