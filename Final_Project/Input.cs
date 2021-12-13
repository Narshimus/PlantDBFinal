using System;
using System.Linq;
using System.Collections.Generic;


namespace Final_Project
{
    public class Input
    {
        public static void Parse(string input)
        {
            //check if ID
            if (int.TryParse(input, out int num))
            {
                var output = PlantStore.Plants.Where(p => p.Id == input);
                if (!IsEmpty(output)) output.First().PrintVerbose();
            }
            //query strings
            else
            {
                var output = PlantStore.Plants.Where(p => p.CommonName.ToLower().Contains(input));
                if (!IsEmpty(output))
                {
                    int index = 0;
                    foreach (var i in output)
                    {
                        i.Print();
                        index++;
                        if (index % 10 == 0)
                        {
                            Console.ReadLine();
                        }
                    }
                }
            }
        }

        public static bool IsEmpty(IEnumerable<Plant> p)
        {
            if(p.Count() == 0)
            {
                Console.WriteLine("Query returned no results...");
                return true;
            }
            return false;
        }
    }
}
