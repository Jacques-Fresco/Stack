using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStack.Model
{
    class NStack<T> : ICloneable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count; // кол.во элементов
        public bool IsEmpty => items.Count == 0;
        public void Push(T item) // протолкнуть элемент
        {
            items.Add(item);
        }
        public void Clear() // очистка списка
        {
            items.Clear();
        }
        public T Pop() // извлечение первого элемента, если такой есть
        {
            if(!IsEmpty)
            {
                T item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        public T Peek() // посмотреть первый элемент
        {
            if(!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        public override string ToString()
        {
            return $"Стек с {Count} элементами.";
        }

        public object Clone()
        {
            NStack<T> nStack = new NStack<T>();
            nStack.items = new List<T>(items);
            return nStack;
        }
    }
}
