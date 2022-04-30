using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Queue<T>
    {
        LinkedList<T> MyList;
        public Queue()
        {
            this.MyList = new LinkedList<T>();
        }
        public void Enqueue(T obj)
        {
            MyList.AddLast(obj);
        }
        public T Dequeue()
        {
            if (MyList.Count > 0)
            {
                T top = MyList.First();
                MyList.Remove(MyList.First());
                return top;
            }
            else
            {
                throw new InvalidOperationException();
            }
           
        }
        public T Peek()
        {
            if (MyList.Count > 0)
            {
                return MyList.Last();
            }
            else
            {
                throw new InvalidOperationException();
            }            
        }       
        public void Clear()
        {
            MyList.Clear();
        }
        public int Count()
        {
            return MyList.Count();
        }


    }
}
