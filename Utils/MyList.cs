using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MyList
    {
        public MyNode head { get; set; }
        public int count { get; set; }
        public MyList()
        {
            head = null;
            count = 0;
        }
        public void Add(int inf)
        {
            MyNode p = new MyNode(inf, head);
            head = p;
            count++;
        }
        public string Printer()
        {
            string[] st = new string[0];
            string str = String.Empty;
            int L = 0;
            MyNode p = head;
            if (p != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = p.inf.ToString();
                    p = p.next;
                }
                while (p != null);

            foreach (string s in st)
            {
                str += s + " ";
            }
            return str;
        }
        public MyNode FindNode(int val)
        {
            MyNode p = head;
            bool ok = false;
            while((p !=null) && !ok)
            {
                ok = p.inf == val;
                if (!ok)
                {
                    p = p.next;
                }
            }
            return p;
        }
        public void Delete(int index)
        {
            if(index != 0)
            {
                MyNode p = head;
                for(int i = 0; i < index - 1; i++)
                {
                    p = p.next;
                }
                if(p.next != null)
                {
                    p.next = p.next.next;
                }
            }
            else
            {
                head = head.next;
            }
            count--;
        }
        public void Insert(int index, int val)
        {
            if (index != 0)
            {
                MyNode p = head;
                for (int i = 0; i < index; i++)
                {
                    p = p.next;
                }
                MyNode q = new MyNode(val, p.next);
                p.next = q;
            }
            else
            {
                MyNode q = new MyNode(val, head);
                head = q;
            }
            count++;
        }
        public int Max()
        {
            MyNode p = head;
            bool ok = false;
            int max = p.inf;
            while (p.next != null)
            {
                ok = p.inf<p.next.inf;
                if (ok)
                {
                    max = p.next.inf;
                }
                p = p.next;
            }
            //if (p.inf > max)
            //{
            //    max = p.inf;
            //}
            return max;
        }
        public int Find(int val)
        {
            MyNode p = head;
            int k = 0;
            while (p != null)
            {
                if (p.inf == val)
                {
                    k++;
                }
                p = p.next;
            }
            return k;
        }

        public int CountMax()
        {
            if (head == null)
                return 0;
            MyNode p = head;
            int max = p.inf;
            int count = 0;
            while (p!= null)
            {
                if (p.inf == max)
                    count++;
                else if (p.inf > max)
                {
                    max = p.inf; count = 1;
                }
                p = p.next;
            }
            return count;
            //return Find(Max());
        }
    }
}
