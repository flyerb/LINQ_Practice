using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
         
            IList<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var result = words.Where(w => w.Contains("bike"));

            foreach( var str in result)
            {
                Console.WriteLine(str);
            }


            //***************************************************************************

            //returns a copy without a duplicate

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            var distinct = names.Distinct().ToList();
            foreach (string name in distinct)
            {
                Console.WriteLine(name);
            }

            //**************************************************************************


            IList<string> classGrades = new List<string>(){ "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"};



            var lowestDropped = classGrades.Where(c => c.

            
            Console.WriteLine();

            //lowestDropped.Where(c => c > 69);

            //foreach (var grade in lowestDropped)
            //{
            //    Console.WriteLine(grade);
            //}

            //convert string to int-
            //drop last score ( could use substring)

        }
    }
}
