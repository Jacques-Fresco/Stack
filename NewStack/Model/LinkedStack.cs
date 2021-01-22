using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStack.Model
{
    class LinkedStack<T>
    {
        // public Item<T> Root { get; set; }
        public Item<T> Head { get; set; }
        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }
        public LinkedStack(T data)
        {
            Head = new Item<T>(data);
            Count = 1;
        }
        public void Push(T data) // протолкнуть элемент
        {
            Item<T> item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public T Pop() // извлечение первого элемента, если такой есть
        {
            if (Count > 0)
            {

                Item<T> item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }
        public T Peek() // посмотреть первый элемент
        {
            if(Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }
    }
}
