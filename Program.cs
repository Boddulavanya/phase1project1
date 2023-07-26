using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConAppPhase1Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path to the text file
            string filePath = "Documents\\student";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Display the student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }

            Console.ReadLine();
        }
    }
    }

