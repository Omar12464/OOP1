using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string model;
        private double speed;
        #endregion

        #region Properties
        public double Speed
        {
            get { return Speed; }
            set { Speed = value; }
        }

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Model
        {
            get
            {

                return Model;
            }
            set
            {
                Model = value;
            }

        }


        #endregion

        #region Constructor
        public Car(int id, string _model, double _speed)
        {
            this.id = id;
            model = _model;
            speed = _speed;
        }
        public Car(int id) : this(id, "Bm", 500)
        {
            this.id = id;
        } 
        #endregion

        public override string ToString()
        {
            return $"Id: {id}\n model:{model}\n Speed:{speed}";
        }
    }
}
