using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml;

namespace MyDeque {
    public class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoubleNode<T> Previous { get; set; }
        public DoubleNode<T> Next { get; set; }
    }
    public class MyDeque<T> : IEnumerable<T>
    {
        DoubleNode<T> head;
        DoubleNode<T> tail;
        int count;

        public void AddLast(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }
        public T RemoveFirst()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }
        public T RemoveLast()
        {
            T output = tail.Data;
            if (count == 0)
            {
                throw new InvalidOperationException();
            } else if (count == 1)
            {
                tail = head = null;
                tail.Next = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return tail.Data;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public T First
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                }
                return head.Data;
            }
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            DoubleNode<T> current = head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}