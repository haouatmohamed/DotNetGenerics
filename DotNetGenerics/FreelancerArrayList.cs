using System;

namespace DotNetGenerics
{
    internal sealed class FreelancerArrayList
    {
        private Freelancer[] _freelancers;
        private int _size;

        public FreelancerArrayList(int initialCapacity)
        {
            _freelancers = new Freelancer[initialCapacity];
        }

        public void Add(Freelancer freelancer)
        {
            if (_size < _freelancers.Length - 1)
            {
                _freelancers[_size] = freelancer;
                _size++;
            }
            else
            {
                var newEmployeeCollection = new Freelancer[_freelancers.Length * 2];
                for (int i = 0; i < _freelancers.Length; i++)
                {
                    newEmployeeCollection[i] = _freelancers[i];
                }

                newEmployeeCollection[_freelancers.Length + 1] = freelancer;
                _size = _freelancers.Length + 1;
                _freelancers = newEmployeeCollection;
            }
        }

        public Freelancer this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                return _freelancers[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                _freelancers[index] = value;
            }
        }
    }
}
