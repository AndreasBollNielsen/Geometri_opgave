using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    class Rectangel : Square
    {
        private float b;

        public float B
        {
            get { return b; }
            set { b = value; }
        }



        public Rectangel(float _a, float _b) : base(_a)
        {
            this.A = _a;
            this.B = _b;
        }

        public override float Calc_perimeter()
        {
            float perimeter = (A * 2) + (B * 2);
            return perimeter;
        }

        public override float Calc_Area()
        {
            float Area = A * B;
            return Area;
        }
    }
}
