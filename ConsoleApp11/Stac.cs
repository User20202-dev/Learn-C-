using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Stak<T> : IEnumerable<T>
    {
        private T[] _items;
        public int Count { get; set; }
        
        public int Capacity
        {
            get { return _items.Length; }
        }
        
        public Stak()
        {
            const int defaultcapacity = 4;
            _items = new T[defaultcapacity];

        }
        public Stak(int capacity)
        {
            _items = new T[capacity];
        }
        public void Push(T item)
        {
          if(_items.Length == Count)
          {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
          }
           _items[Count++] = item;

        }
        public void Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[Count--] = default(T);
        }
        public T Peek()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];   
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumarator<T>(_items, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
    public class StackEnumarator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private int position = -1;
        private readonly int count;
        public StackEnumarator(T[] array, int count)
        {
            this.array = array;
            this.count = count;

            position = count;
        }

        public T Current
        {
            get
            {
                return array[position]; 

            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current; 
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position++;
            return position >= 0;
        }

        public void Reset()
        {
           position = count;
        }
    }
}
