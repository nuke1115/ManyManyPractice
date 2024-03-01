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
