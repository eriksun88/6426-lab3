using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Test
    {

        Queue<int> MyQueue;
        Random Rdm;
        public Test(Queue<int> queue)
        {
            MyQueue = queue;
            Rdm = new Random();
        }

        private int GenerateRandomNum()
        {
            int num = Rdm.Next();
            Console.WriteLine("Generate Number is {0}", num);
            return num;
        }

        public void DoEnqueue()
        {
            MyQueue.Enqueue(GenerateRandomNum());
        }
        public void DoDequeue()
        {
            int result = MyQueue.Dequeue();
            Console.WriteLine("The result for Dequeue is {0}", result);
            Console.WriteLine("After Dequeue, total number of elements in the stack are {0}", MyQueue.Count());
        }
        public void DoPeek()
        {
            int result = MyQueue.Peek();
            Console.WriteLine("The result for Peek is {0}", result);
            Console.WriteLine("After Peek, total number of elements in the stack are {0}", MyQueue.Count());
        }
        public void DoClear()
        {
            MyQueue.Clear();
            Console.WriteLine("After Clear, total number of elements in the stack are {0}", MyQueue.Count());
        }


    }
}
