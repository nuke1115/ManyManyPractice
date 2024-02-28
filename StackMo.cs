
namespace aSimpleStack
{
    public class SimpleStack<T>
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

        public new Type GetType { get => _type; }

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
}