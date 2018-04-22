using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MyNode
    {
        public int inf { get; set; }
        public MyNode next { get; set; }
        public MyNode(int inf, MyNode next)
        {
            this.inf = inf;
            this.next = next;

        }
    }
}
