using System;

namespace DotNetGenerics
{
    internal sealed class GenericArrayList
    {
        private object[] _items;
        private int _size;

        public GenericArrayList(int initialCapacity)
        {
            _items = new object[initialCapacity];
        }

        public void Add(object item)
        {
            if (_size < _items.Length - 1)
            {
                _items[_size] = item;
                _size++;
            }
            else
            {
                var newEmployeeCollection = new object[_items.Length * 2];
                for (int i = 0; i < _items.Length; i++)
                {
                    newEmployeeCollection[i] = _items[i];
                }

                newEmployeeCollection[_items.Length + 1] = item;
                _size = _items.Length + 1;
                _items = newEmployeeCollection;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                _items[index] = value;
            }
        }
    }
}
