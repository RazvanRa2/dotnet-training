using System;
using System.Collections.Generic;
namespace lab4___LinkedList
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

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void Print()
        {
            // same as get last node, use a temp node to iterate
            // be sure to check that the list is not empty (this.head == null) in that case
            // you might want to use a do...while structure

            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine($"node.data is {temp.data}");
                temp = temp.next;
            }
        }

        internal void InsertFront(int new_data)
        {
            // create a new node using the constructor
            // make the .next propriety of that node equal to current head
            // make the head equal to the new node
            Node newNode = new Node(new_data);
            newNode.next = head;
            head = newNode;
        }

        internal void InsertLast(int new_data)
        {
            // create a new node
            // if the list is empty, make the head equal to the new node
            // regardless of list size, GetLastNode() and make the lastnode.next equal to the new node
            // to link the newely created node to the list

            Node newNode = new Node(new_data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            GetLastNode().next = newNode;
        }

        internal void InsertAfter(Node prev_node, int new_data)
        {
            // make sure to check that prev_node is not null.
            // if prev_node is null, just "return;"
            // if the prev_node is not null, then create a new node
            // the new_node.next should be equal to the prev_node.next
            // the prev_node.next should be equal to the new node
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }

            Node newNode = new Node(new_data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
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

            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void ReverseLinkedList()
        {
            // this is a challenge.
            // the instructions you are looking for
            // are in an other castle
            Node prev = null;
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
    }


    internal class Stack : SingleLinkedList
    {
        // pushes data onto the stack
        internal void Push(int data)
        {

        }

        // removes the top of the stack and returns the value from
        // the removed node
        // todo: what if the stack is empty? handle that case
        internal int Pop()
        {
            return 0;
        }

        // prints the value from the node at the top
        // todo: what if the stack is empty?
        internal void Peek()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack();

            myStack.Push(1);
            myStack.Push(2);

            Console.WriteLine(myStack.Pop());  // 2
            Console.WriteLine(myStack.Pop());  // 1
            Console.WriteLine(myStack.Pop());  // error code or exception

            myStack.Push(3);
            myStack.Peek();
            myStack.Pop();
            myStack.Peek();
        }
    }
}
