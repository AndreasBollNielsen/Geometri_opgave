using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    public class Shape
    {
        private float a;

        public float A
        {
            get { return a; }
            set { a = value; }
        }

        public Shape(float _a)
        {
            this.A = _a;
        }

       


        public virtual float Calc_perimeter()
        {
            return 0;
        }

        public virtual float Calc_Area()
        {
            return 0;
        }
    }
}
