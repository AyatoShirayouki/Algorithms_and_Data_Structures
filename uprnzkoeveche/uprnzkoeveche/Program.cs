using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprnzkoeveche
{
    public class ArrayStack<T>
    {
        private const int initialCapacity = 4;
        private T[] elements;

        public ArrayStack(int capacity = initialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }
        public T Peek { get; private set; }
        private T peek2
        {
            get
            {
                return elements[Count - 1];
            }
        }

        public void Push(T elemnet)
        {
            if (Count == elements.Length)
            {
                Array.Resize(ref elements, Count*2);
            }
            elements[Count] = elemnet;
            Peek = elemnet;
            Count++;
        }
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            Count--;
            Peek = elements[Count - 1];
            return elements[Count];
        }
    }
    public class StackNode<T>
    {
        public StackNode<T> NextNode { get; set; }
        public T Value { get; set; }
        public StackNode(T value, StackNode<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }
    }
    public class linkedStack<T>
    {
        public int count { get; private set; }
        public StackNode<T> peek { get; private set; }
        public void push(T element)
        {
            peek = new StackNode<T>(element, peek);
            count++;
        }
        public T Pop()
        {
            var removedNode = peek.Value;
            peek = peek.NextNode;
            count--;
            return removedNode;
        }
        public linkedStack()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
