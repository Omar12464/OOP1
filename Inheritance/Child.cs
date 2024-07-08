using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Inheritance
{
    internal class Child : Parent
    {
        public int Z
        {
            get;
            set;

        }

        public Child(int _x,int _y,int z):base(_x,_y)
        {
            this.Z = z;

        }

        public new int Product()
        {
            return X*Y*Z;
        }
        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }
    }
}
