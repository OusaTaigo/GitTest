using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBashTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "Hello World";
            int id = 1;

            float novoCommitTest = 0.6f;
            int hey = (int)Math.Floor(id - novoCommitTest);
            Console.WriteLine(intro);
            Console.WriteLine(id.ToString());
            Console.WriteLine(hey.ToString());
            Console.ReadLine();
        }
    }
}
