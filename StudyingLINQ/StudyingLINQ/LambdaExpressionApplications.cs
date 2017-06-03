using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingLINQ
{
    class LambdaExpressionApplications
    {
        //Creation of List
        public IEnumerable<string> nameList = new List<string> { "Pedro", "Mario", "Guilherme", "Marcos", "Mariana", "Julia" };

        //Using Helper Method
        public void WithMethod()
        {
            foreach (var name in nameList.Where(StartingWithM))
            {
                Console.WriteLine(name);
            }
        }

        //Using Delegate
        public void WithDelegate()
        {
            foreach (var name in nameList.Where(delegate(string name)
            { return name.StartsWith("M");}))
            {
                Console.WriteLine(name);
            }
        }

        //Using LambdaExpression
        public void WithLambda()
        {
            foreach (var name in nameList.Where(n => n.StartsWith("M")))
            {
                Console.WriteLine(name);
            }
        }

        private bool StartingWithM(string name)
        {
            return name.StartsWith("M");
        }

        public void SortStartingWithM()
        {
            //foreach (var name in nameList.Where(n => n.StartsWith("M"))
            //    .OrderByDescending(n => n))
            //{
            //    Console.WriteLine(name);
            //}

            foreach (var name in from name in nameList
                                 where name.StartsWith("M")
                                 orderby name
                                 select name
                )
            {
                Console.WriteLine(name);
            }
        }

        public void TestMethods()
        {
            var lea = new LambdaExpressionApplications();
            Console.WriteLine("Filtering List with Helper Function");
            lea.WithMethod();
            Console.WriteLine("********");
            Console.WriteLine( );
            Console.WriteLine("Filtering List with Delegate Function");
            lea.WithDelegate();
            Console.WriteLine("********");
            Console.WriteLine();
            Console.WriteLine("Filtering List with Lambda Expression");
            lea.WithLambda();
        }

        public void WriteOrderedList()
        {
            SortStartingWithM();
        }
    }
}
