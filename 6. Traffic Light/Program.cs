using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Traffic_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            int counter = 0;

            string command = string.Empty;

            while (command == "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} has passed");
                            counter++;
                        } 
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{counter}cars passed the crossroads.");
        }
    }
}
