using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                This project will show you some ways in which references, inheritance, interfaces,
                and arrays can help you be a better C# programmer.


                 Author: Ricardo Carvalheira
             */
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };

            Console.WriteLine("Result without the interface: \r\n");


            DirectAll(rovers);

            Object[] spaceProbes = { lunokhod, apollo, sojourner, sputnik };

            IDirectable[] spaceProbesInterface = { lunokhod, apollo, sojourner, sputnik };

            Console.WriteLine("Result using the interface: \r\n");
            DirectAll(spaceProbesInterface);

            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();


        }

        static void DirectAll(Rover[] rovers)
        {
            foreach (Rover r in rovers)
            {
                Console.WriteLine(r.GetInfo());
                Console.WriteLine(r.Explore());
                Console.WriteLine(r.Collect());
            }

        }

        static void DirectAll(IDirectable[] rovers)
        {
            foreach (IDirectable r in rovers)
            {
                Console.WriteLine(r.GetInfo());
                Console.WriteLine(r.Explore());
                Console.WriteLine(r.Collect());
            }

        }
    }
}
