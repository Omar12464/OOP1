using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct PhoneBook
    {
        #region Attributes
        private string[] names;
        long[] numbers;
        int size;
        #endregion

        public int Size //readonly property
        {
            get { return size; }
            private set { size = value; }
        }
        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        public void addPerson(int position, string name, long phNumber)
        {
            if (names is not null && numbers is not null)
            {
                if (position > 0 || position > size)
                {
                    names[position] = name;
                    numbers[position] = phNumber;
                }
            }
        }
        public long getNumber(string name)
        {
            if (name is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;

        }

        public void SetNumber(string name, long phNumber)
        {
            if (name is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = phNumber;
                        return;
                    }
                }
            }
        }

        #region Indexer
        public long this[string name]
            {
             get
             {
                if (name is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
             }
            set
            {
                if (name is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            return;
                        }
                    }
                }
            }
            }

        public string this[int pos]
        {
            get
            {
                return $"Position :{pos} Name:{names[pos]} number: {numbers[pos]}";
            }
        }
        #endregion
    }
}
