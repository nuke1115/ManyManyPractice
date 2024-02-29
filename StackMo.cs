
namespace aSimpleStack
{
    public class SimpleStack<T> //혼자서 구현해본것
    {
        private int _count = 0;
        private int _index = -1;
        private List<T> _internalList;
        private Type _type;

        public SimpleStack()
        {
            _internalList = new List<T>();
            _type = typeof(T);
        }

        public int Count { get => _count; }

        public Type GetItemType { get => _type; }

        public void Clear()
        {
            _count = 0;
            _index = -1;
            _internalList.Clear();
        }

        public void Push(T Value)
        {
            _index++;
            _count++;
            _internalList.Add(Value);
        }

        public T Pop()
        {
            T returnValue = _internalList[_index];
            _internalList.RemoveAt(_index);
            _count--;
            _index--;
            return returnValue;
        }

        public T Peek()
        {
            return _internalList[_index];
        }
        
        public bool Contains(T Value)
        {
            return _count != 0 && _internalList.LastIndexOf(Value) != -1;
        }


    }

    public class SimpleArrayStack<T> //c# 기본제공 Stack클래스 참고
    {
        private uint _count;
        private uint _index;
        private Type _type;
        private T[] _internalArray;
        private const uint _defaultCapacity = 4;


        public SimpleArrayStack()
        {
            _type = typeof(T);
            _internalArray = Array.Empty<T>();
        }

        public Type GetItemType { get => _type; }

        public uint Count { get => _count; }


        public T Peek()
        {
            return _internalArray[_index - 1];
        }

        public T Pop()
        {
            T tmp = _internalArray[_index - 1];
            _internalArray[_index - 1] = default!;
            _count--;
            _index--;
            return tmp;
        }
        public void Push(T Value)
        {
            _index++;
            if (_index < _internalArray.Length){

                _internalArray[_index - 1] = Value;

                _count++;
            }
            else
            {
                PushWithGorwCapacity(Value);
            }
        }

        private void PushWithGorwCapacity(T Value)
        {
            Grow();
            _count++;
            _internalArray[_index - 1] = Value;
        }

        private void Grow()
        {
            int newCapacity = _internalArray.Length == 0 ? (int)_defaultCapacity : _internalArray.Length * 2;

            Array.Resize<T>(ref _internalArray, newCapacity);
        }

        public bool Contains(T Value)
        {
            return _count != 0 && Array.LastIndexOf(_internalArray, Value) >= 0;
        }

    }
}