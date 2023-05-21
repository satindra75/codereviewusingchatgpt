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
}
