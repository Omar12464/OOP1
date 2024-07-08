using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Inheritance
{
    internal class Parent
    {
		private int x;
		private int y;

        #region Properties
        public int X
        {
            get { return X; }
            set { X = value; }
        }
        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }
        #endregion

        public Parent(int x,int y) { this.x = x;this.y = y; }
        public Parent()
        {

        }

        public override string ToString()
        {
            return $"{x} {y}";
        }

        public virtual int Product()
        {
            return x*y; 
        }
    }
}
