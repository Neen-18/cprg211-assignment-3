using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        Node head;
        Node tail;
        int size;

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public int Size1 { get => size; set => size = value; }

        public SLL()
        {
            Head = Tail = null;
            size = 0;
        }
        public void Append(object data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Succesor = newNode;
                Tail = Tail.Succesor;
            }
            size++;
        }
        //Clear all items in the linked list.
        public void Clear()
        {
            //throw new NotImplementedException();
            Head = Tail = null;
            size = 0;
        }

        public bool Contains(object data)
        {
            //throw new NotImplementedException();
            for (Node tempNode = Head; tempNode != null; tempNode = tempNode.Succesor)
            {
                if (tempNode.Element.Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        public void Delete(int index)
        {
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                Head = Head.Succesor;
                if (Head == null) Tail = null;
            }
            else
            {
                Node prev = Head;
                for (int i = 1; i < index; i++)
                    prev = prev.Succesor;
                prev.Succesor = prev.Succesor.Succesor;
                if (index == size - 1)
                {
                    Tail = prev;
                }
            }
            size--;
        }
        //Get the index of an item in the linked list.
        public int IndexOf(object data)
        {
            //throw new NotImplementedException();
            int idx = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Succesor, idx++)
            {

                if (tempNode.Element.Equals(data))
                {
                    return idx;
                }
            }
            return -1;
        }
        //Insert an item at a specific index in the linked list.
        public void Insert(object data, int index)
        {
            //throw new NotImplementedException();
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                Prepend(data);
                return;
            }
            else if (index == size - 1)
            {
                Append(data);
                return;
            }
            Node current = head;
            Node newNode = new Node(data);
            for (int i = 0; i < index-1; i++)
            {
                current = current.Succesor;
            }
            newNode.Succesor = current.Succesor;
            current.Succesor = newNode;
            size++;
        }
        //Check if the linked list has an item
        public bool IsEmpty()
        {
            //throw new NotImplementedException();
            return head == null;
        }

        public void Prepend(object data)
        {
            //throw new NotImplementedException();
            head = new Node(data, head);
            if (tail == null)
            {
                tail = head;
            }
            size++;
        }
        //Replace an item in the linked list
        public void Replace(object data, int index)
        {
            //throw new NotImplementedException();
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            int count = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Succesor, count++)
            {
                if (count == index)
                {
                    tempNode.Element = data;
                    return;
                }
            }
        }
        //Get an item at an index in the linked list
        public object Retrieve(int index)
        {
            //throw new NotImplementedException();
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }

            int count = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Succesor, count++)
            {
                if (count == index)
                {
                    return tempNode.Element;
                }
            }
            return null;
        }
        //Get the number of items in the linked list.
        public int Size()
        {
            return size;
        }
    }
}