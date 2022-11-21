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
        public void insertnode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.rollNumber = nim;
            newNode.name = nm;

            if (LAST == null || nim <= LAST.rollNumber)
            {
                if ((LAST != null) && (nim == LAST.rollNumber))
                {
                    Console.WriteLine("\nDulpicate number not allowed");
                    return;
                }
                newNode.next = LAST;
                if (LAST != null)
                    LAST.prev = newNode;
                newNode.prev = null;
                LAST = newNode;
                return;
            }
            Node previous, current;
            for (current = previous = LAST; current != null && nim >= current.rollNumber; previous = current, current = current.next)
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\nDulicate roll numbers not allowed");
                    return;
                }
            }
            newNode.next = current;
            newNode.prev = previous;

            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
