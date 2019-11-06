using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Stack
    {
        int[] array;
        int top=0;
        public void DisplayStack()
        {
            for (int i = top - 1; i <= top - 1; i--)
            {
                Console.WriteLine(array[i]);
                if (i < 1)
                {
                    break;
                }
            }
        }

        public Stack(int s)
        {
            array = new int[s];
        }
        void Push(int val)
        {
            if (top > array.Length - 1)
            {
                array[top] = val;
            }
            else
            {
                array[top] = val;
            }
            top++;
        }

        public bool isEmpty()
        {
            if (array.Length>= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int Pop()
        {
            int value = 0;
            if (isEmpty())
            {
                return 0;
            }
            else
            {
                top--;
                value = array[top];
                return value;
            }
        }
        

        class Program
        {
            static void Main(string[] args)
            {
                Stack sobj = new Stack(3);

                sobj.Push(10);
                sobj.Push(8);
                sobj.Push(36);
                Console.WriteLine("First Stack:");
                sobj.DisplayStack();
                sobj.Pop();
                sobj.Pop();
                Console.WriteLine("After Pop Elements From Stack:");
                sobj.DisplayStack();
                sobj.Push(100);
                sobj.Push(90);
                Console.WriteLine("New Stack After Push Values:");
                sobj.DisplayStack();
                Console.ReadLine();
            }
        }
    }
}
