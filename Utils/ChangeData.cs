using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ChangeData
    {
        //List
        public static void Change(string str, MyList list)
        {
            string[] arr = str.Split(new Char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < arr.Length; i++)
            {
                list.Add(Convert.ToInt32(arr[i]));
            }
        }
        //Stack
        private static void ReturnStack(MyStack stack1, MyStack stack2, int k1, int k2)
        {
                for (int i = 0; i < k2 - k1; i++)
                {
                    stack2.Push(stack1.Pop());
                }
        }
        public static int CheckStack(MyStack stack1, MyStack stack2)
        {
            int k1 = 0;
            int k2 = 0;
            while (!stack1.isEmpty())
            {
                stack2.Push(stack1.Pop());
                k1++;
            }
            while (!stack2.isEmpty())
            {
                stack1.Push(stack2.Pop());
                k2++;
            }
            ReturnStack(stack1, stack2, k1, k2);
            return k2;
        }
        //Queue
        public static int CheckQueue(MyQueue queue1, MyQueue queue2)
        {
            double x, y;
            int k = 0;
            while ((!queue1.isEmpty()) && (!queue2.isEmpty()))
            {
                x = (double)queue1.Pop();
                y = (double)queue2.Pop();
                if (x < y)
                {
                    queue1.Push(x + y);
                }
                else
                {
                    queue2.Push(x - y);
                }
                k++;
            }
            return k;
        }
        //Sort
        public static int[] SortInsertion(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int j = i;
                int tmp = mas[j];
                while (j > 0 && tmp < mas[j - 1])
                {
                    mas[j] = mas[j - 1];
                    j--;
                }
                mas[j] = tmp;
            }
            return mas;
        }

        public static int[] SortBinInsert(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int tmp = a[i], left = 0, right = i-1;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    if (tmp < a[m])
                        right = m - 1;
                    else left = m + 1;
                }
                for (int j = i-1; j >= left; j--)
                    a[j + 1] = a[j]; 
                a[left] = tmp; 
            }

            return a;
        }
    }
}
