/*
Author: Yihan Wang
Date:   11-10-2015
Description:    Class that implements a generic queue to be used in a bucket sort
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue<T>
    {
        //Create a first and last node for the queue
        private Node first;
        private Node last;
        private int N;

        protected class Node
        {
            T item;
            Node next;
        }

       //Empty queue
        public bool isEmpty() { return N == 0; }
        public int size() { return N; }

        //Place items in the queue
        public void enqueue(T item)
        {
            Node oldlast = last;
            last = new Node();
            last.item = item;
            last.next = null;
            if (isEmpty())
                first = last;
            else
                oldlast.next = last;
            N++;
        }

        //Remove items from the queue
        public T dequeue()
        {
            T item = first.item;
            first = first.next;
            if (isEmpty())
                last = null;
            N--;
            return item;

        }

    }
}
