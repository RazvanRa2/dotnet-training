using System;
using System.Collections.Generic;
namespace lab3___LinkedList
{

    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class SingleLinkedList
    {
        internal Node head;

        // Return the last not in the list
        internal Node GetLastNode()
        {
            // use a temporary node equal to head for iteration
            // while the .next node exists, continue iteration with temp node
            // return the last node, which will be equal to temp

            // dummy. delete line 29 when implementing.
            return new Node(0);
        }

        internal void Print()
        {
            // same as get last node, use a temp node to iterate
            // be sure to check that the list is not empty (this.head == null) in that case
            // you might want to use a do...while structure
        }

        internal void InsertFront(int new_data)
        {
            // create a new node using the constructor
            // make the .next propriety of that node equal to current head
            // make the head equal to the new node
        }

        internal void InsertLast(int new_data)
        {
            // create a new node
            // if the list is empty, make the head equal to the new node
            // regardless of list size, GetLastNode() and make the lastnode.next equal to the new node
            // to link the newely created node to the list
        }

        internal void InsertAfter(Node prev_node, int new_data)
        {
            // make sure to check that prev_node is not null.
            // if prev_node is null, just "return;"
            // if the prev_node is not null, then create a new node
            // the new_node.next should be equal to the prev_node.next
            // the prev_node.next should be equal to the new node
        }

        internal void DeleteNodebyKey(int key)
        {
            // there are multiple cases here
            // if the node is the head, just remove the head,
            // by making the head equal to head.next

            // if it's not head and the node is in the list somwhere
            // iterate through the list, looking for temp.data

            // when you find the node to be deleted, make (the node before it).next = (that node with data == key).next

            // also, it might be the case that the node is not in the list
            // in that case, you'll reach the end of the list without replacing anything
        }

        public void ReverseLinkedList()
        {
            // this is a challenge.
            // the instructions you are looking for
            // are in an other castle
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // arrays vs lists
            var array = new string[100000000];
            var list = new List<string>(100000000);

            // testing a list

            var myIntegersList = new SingleLinkedList();
            myIntegersList.InsertFront(3);
            myIntegersList.InsertLast(5);
            myIntegersList.InsertAfter(myIntegersList.head, 3);

            var lastNode = myIntegersList.GetLastNode();

            myIntegersList.DeleteNodebyKey(7);
            myIntegersList.DeleteNodebyKey(3);

            myIntegersList.InsertFront(5);
            myIntegersList.InsertFront(4);
            myIntegersList.InsertFront(3);
            myIntegersList.InsertFront(2);
            myIntegersList.InsertFront(1);
            myIntegersList.InsertFront(0);

            myIntegersList.ReverseLinkedList();

            myIntegersList.Print();
        }
    }
}
