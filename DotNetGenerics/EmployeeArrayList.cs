using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGenerics
{
    internal sealed class EmployeeArrayList
    {
        private Employee[] _employees;
        private int size;

        public EmployeeArrayList(int initialCapacity)
        {
            _employees = new Employee[initialCapacity];
        }

        public void Add(Employee employee)
        {
            if (size < _employees.Length - 1)
            {
                _employees[size] = employee;
                size++;
            }
            else
            {
                var newEmployeeCollection = new Employee[_employees.Length * 2];
                for (int i = 0; i < _employees.Length; i++)
                {
                    newEmployeeCollection[i] = _employees[i];
                }

                newEmployeeCollection[_employees.Length + 1] = employee;
                size = _employees.Length + 1;
                _employees = newEmployeeCollection;
            }
        }
    }
}
 