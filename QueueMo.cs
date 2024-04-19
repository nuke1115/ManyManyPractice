using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aSImpleQueue
{
    public class SimpleQueue<T>
    {
        private LinkedList<T> _internalLinkedList;
        private Type _type;

        public SimpleQueue()
        {
            _internalLinkedList = new LinkedList<T>();
            _type = typeof(T);
        }
        
        public int GetItemCount { get => _internalLinkedList.Count; }
        public Type GetItemType { get => _type; }

        public void Enqueue(T item)
        {
            _internalLinkedList.AddLast(item);
        }

        public T Dequeue()
        {
            if (_internalLinkedList.Count > 0)
            {
                T tmp = _internalLinkedList.First();
                _internalLinkedList.RemoveFirst();
                
                return tmp;
            }
            else
            {
                return default(T);
            }
        }
        public T Peek()
        {
            if ( _internalLinkedList.Count > 0)
            {
                return _internalLinkedList.First();
            }
            else
            {
                return default(T);
            }
        }

        public void Clear()
        {
            _internalLinkedList.Clear();
        }

        public bool Contains(T item)
        {
            return _internalLinkedList.Count > 0 && _internalLinkedList.Find(item) != null;
        }

    }
}

namespace aQueue
{
    public class CircularQueue<T>
    {
        private T[] _internalArray;
        private int _frontIndex = 0;
        private int _lastIndex = 0;
        private Type _type;
        private T? _defaultValue;
        private int _count = 0;
        private bool isFull = false;

        public CircularQueue(int capacity)
        {
            _internalArray = new T[capacity];
            _type = typeof(T);
            _defaultValue = default(T);

        }

        public void Enqueue(T item)
        {

            if (!isFull)
            {
                _count++;
                _internalArray[_lastIndex] = item;

                _lastIndex++;
                _lastIndex %= _internalArray.Length;

                if (_frontIndex == _lastIndex)
                {
                    isFull = true;
                }
			}
            else
            {
                Console.WriteLine("queue is full");
                throw new InvalidOperationException();
            }
        }

        public T Dequeue()
        {
            T outTmp = _defaultValue;


            if (_frontIndex != _lastIndex || ((_frontIndex == _lastIndex) && isFull))
            {
                _count--;
                outTmp = _internalArray[_frontIndex];
                _internalArray[_frontIndex] = _defaultValue;

                _frontIndex++;
                _frontIndex %= _internalArray.Length;


                isFull = false;
            }
			else
			{
				Console.WriteLine("queue is empty");
				throw new InvalidOperationException();
			}
			return outTmp;

        }

        public T Peek()
        {
            if (_frontIndex != _lastIndex || (_frontIndex == _lastIndex) && isFull)
			{
                return _internalArray[_frontIndex];
			}
			else
			{
				Console.WriteLine("queue is empty");
				throw new InvalidOperationException();
			}
		}

        public Type GetType()
        {
            return _type;
        }

        public int GetCount()
        {
            return _count;
        }

		public int GetLength()
		{
			return _internalArray.Length;
		}

		public bool isQueueFull()
        {
            return isFull;
        }

        public bool isQueueEmpty()
        {
            return _count == 0;
        }

        public bool Contains(T item)
        {
            bool searchResult = false;

            for (int i = 0; i < _internalArray.Length && !searchResult; i++)
            {
                searchResult = _internalArray[i].Equals(item);
            }
            

            return searchResult;

        }
    }
}