using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MyQueue
    {
        Node top;
        Node tail;
        public bool isEmpty()
        {
            return top == null;
        }
        public object Pop()
        {
            if (top == null) throw new
                        InvalidOperationException();
            object result = top.data;
            top = top.next;
            return result;
        }
        public class Node
        { 
            public object data;
            public Node next;
            public Node(Node next, object data)
            {
                this.next = next;
                this.data = data;
            }
        }
        public void Push(object inf)
        {
            Node p = new Node(null, inf);
            if (isEmpty())
            {
                top = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
            }
        }
    }
}
