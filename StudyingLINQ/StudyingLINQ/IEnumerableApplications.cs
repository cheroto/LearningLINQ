using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingLINQ
{
    class IEnumerableApplications
    {
        //Creation of Static Array
        public IEnumerable<string> nameArray = new string[]{ "Pedro", "Mario", "Guilherme", "Marcos", "Mariana", "Julia" };

        //Creation of Static List
        public IEnumerable<string> nameList = new List<string>{ "Pedro", "Mario", "Guilherme", "Marcos", "Mariana", "Julia" };

        //Print Array
        public void PrintArray()
        {
            foreach (var name in nameArray)
            {
                Console.WriteLine(name);
            }
        }

        //Print List
        public void PrintList()
        {
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
        }

        //Print IEnumarable
        public void PrintIEnumerable(IEnumerable<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void TestImplementation()
        {
            var IA = new IEnumerableApplications();
            IA.PrintArray();
            Console.WriteLine("********");
            IA.PrintList();
            Console.WriteLine("********");
            IA.PrintIEnumerable(nameList);
            Console.WriteLine("********");
            IA.PrintIEnumerable(nameArray);
        }

        public void TestCountExtension()
        {
            var IA = new IEnumerableApplications();
            var listCount = nameList.Count();
            Console.WriteLine("Number of items in list: {0:D}", listCount);
        }
    }
}
