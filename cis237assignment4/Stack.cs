/*
Author: Yihan Wang
Date:   11-10-2015
Description:    Class that implements a generic stack to be used in a bucket sort
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Generic Stack
    class Stack<T>
    {
        private T[] a;
        private int N = 0;
        public bool isEmpty() { return N == 0; }
        public int size() { return N; }

        private void resize(int max)
        {
            T[] temp;
            for (int i = 0; i < N; i++)
                temp[i] = a[i];
            a = temp;
        }

        public void push(T item)
        {
            if (N == a.Length)
                resize(2 * a.Length);
            a[N++] = item;
        }

        public T pop()
        {
            T item = a[--N];
            a[N] = null;
            if (N > 0 && N == a.Length / 4)
                resize(a.Length/2);
           
            return item;
        }
    }
}
