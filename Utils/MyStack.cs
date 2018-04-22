using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MyStack
    {
        Node top;
        public void Push(object data)
        //положить в стек
        {
            top = new Node(top, data);
        }
        public object Pop()// взять из стека
        {
            if (top == null) throw new
                InvalidOperationException();
            object result = top.data;
            top = top.next;
            return result;
        }
        public bool isEmpty()// проверка на пустоту
        {
            return top == null;
        }

        class Node  //узел
        {
            public Node next;
            public object data;
            public Node(Node next, object data)
            {
                this.next = next;
                this.data = data;
            }
        }
    }
}
