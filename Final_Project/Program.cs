using System;
using System.Threading;
namespace Final_Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PlantStore.Initializer();
            if(args.Length == 0)
            {
                User.CommandLine();
            }
            else
            {
                Input.Parse(string.Join(" ", args));
            }

        }
    }
}
