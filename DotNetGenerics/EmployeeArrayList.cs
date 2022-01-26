using System;

namespace DotNetGenerics
{
    internal sealed class EmployeeArrayList
    {
        private Employee[] _employees;
        private int _size;

        public EmployeeArrayList(int initialCapacity)
        {
            _employees = new Employee[initialCapacity];
        }

        public void Add(Employee employee)
        {
            if (_size < _employees.Length - 1)
            {
                _employees[_size] = employee;
                _size++;
            }
            else
            {
                var newEmployeeCollection = new Employee[_employees.Length * 2];
                for (int i = 0; i < _employees.Length; i++)
                {
                    newEmployeeCollection[i] = _employees[i];
                }

                newEmployeeCollection[_employees.Length + 1] = employee;
                _size = _employees.Length + 1;
                _employees = newEmployeeCollection;
            }
        }

        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                return _employees[index]; 
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                _employees[index] = value;
            }
        }
    }
}
 