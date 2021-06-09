using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    public class Square : Shape
    {
        private float a;

        public float A
        {
            get { return a; }
            set { a = value; }
        }

        public Square(float _a) : base(_a)
        {
            this.a = _a;
        }

        public override float Calc_perimeter()
        {
            float perimeter = 4 * a;
            return perimeter;
        }

        //calculate Area
        public override float Calc_Area()
        {
            float area = MathF.Pow(A, 2);
            return area;
        }
    }
}
