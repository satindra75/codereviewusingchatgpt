using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    interface IQueue<T>
    {
          void push(T val);
          T pop();
          T peekAtFirst();
          T peekAtLast();
    }

    class ObjectAdapter<T> : IQueue<T>
    {
        List<T> adaptee = new List<T>();
        public void push(T val)
        {
            adaptee.Insert(0, val);
        }

        public T pop()
        {
            T val = adaptee[adaptee.Count - 1];
            adaptee.RemoveAt(adaptee.Count - 1);
            return val;
        }

        public T peekAtFirst()
        {
            return adaptee[0];
        }

        public T peekAtLast()
        {
            return adaptee[adaptee.Count - 1];
        }
    }
}
