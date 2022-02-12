using System.Collections;


namespace Task_3_2
{
    public class DynamicArray<T> : ICollection<T>
    {
        private int _size;
        private int _position;
        private T[] _array;
        public DynamicArray()
        {
            _size = 8;
            _array = new T[_size];
            _position = 0;
        }

        public DynamicArray(int size)
        {
            _size = size;
            _array = new T[_size];
            _position = 0;
        }

        public DynamicArray(IEnumerable<T> inputCollection, int length)
        {
            if (inputCollection == null)
            {
                _size = 8;
                _array = new T[_size];
                _position = 0;
            }

            _array = new T[inputCollection.Count()];
            (inputCollection.ToArray()).CopyTo(_array, 0);
            _size = inputCollection.Count();
            _position = length;
        }

        private void IncreaseArray()
        {
            int _newSize = _array.Length * 2;

            T[] _largerArray = new T[_newSize];

            _array.CopyTo(_largerArray, 0);

            _array = _largerArray;

            _size = _largerArray.Length;

        }

        public int Count => _size;

        public int Length => _position;

        public int Capacity => _size;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (_position < _array.Length)
            {
                _array[_position] = item;
                _position++;


            }
            else if (_position == _array.Length)
            {
                IncreaseArray();
                _array[_position] = item;
                _position++;
            }


        }

        public void RemoveAt(int index)
        {
            if (index >= _position)
            {
                throw new IndexOutOfRangeException();
            }
            int shiftStart = index + 1;
            if (shiftStart < _position)
            {
                Array.Copy(_array, shiftStart, _array, index, _position - shiftStart);
            }
            _position--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _position; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void AddRange(IEnumerable<T> inputCollection, int length)
        {

            while (length > _size - _position)
            {
                IncreaseArray();
            }


            T[] _arrayTemp = new T[inputCollection.Count()];
            (inputCollection.ToArray()).CopyTo(_arrayTemp, 0);

            for (int i = _position; i < _arrayTemp.Length;++i)
            {
                _array[i] = _arrayTemp[i-_position];
            }
            _position += _position+length;



        }


        public void Insert(int index, T item)
        {
            if (index >= _size)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_array.Length == _position)
            {
                IncreaseArray();
            }

            Array.Copy(_array, index, _array, index + 1, _position - index);

            _array[index] = item;

            _position++;
        }


        public T this[int index]
        {
            get

            {
                try
                {
                    return _array[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            set => _array[index] = value;

        }

        public void Clear()
        {
            for (int i = 0; i < _size; ++i)
            {
                Remove(_array[i]);
            }
        }

        public bool Contains(T item)
        {
            foreach (T value in _array)
            {
                if (value.Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_array, 0, array, arrayIndex, _size);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator(_array, _position);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DynamicArrayEnumerator(_array, _position);
        }

        public class DynamicArrayEnumerator : IEnumerator<T>
        {
            public T[] _arrayEnum;

            int _index = -1;

            int _capacity;

            public DynamicArrayEnumerator(T[] list, int capacity)
            {
                _arrayEnum = list;
                _capacity = capacity;
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return _arrayEnum[_index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new IndexOutOfRangeException();
                    }



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
                _index++;
                return (_index < _capacity);
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }

}
