﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }

    class CircularLinked
    {
        Node LAST;
        public CircularLinked()
        {
            LAST = null;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
