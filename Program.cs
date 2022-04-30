//zhiyuan sun 1459462 lab3
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Test test = new Test(queue);
            test.DoEnqueue();
            test.DoEnqueue();
            test.DoEnqueue();
            test.DoEnqueue();
            test.DoPeek();
            test.DoDequeue();
            test.DoClear();
            Console.ReadLine();
        }
        
    }

}
