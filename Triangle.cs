using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    class Triangle : Shape
    {
        private float b;
        private float c;

        public float C
        {
            get { return c; }
            set { c = value; }
        }


        public float B
        {
            get { return b; }
            set { b = value; }
        }


        public Triangle(float _a, float _b) : base(_a)
        {
            this.A = _a;
            this.B = _b;
        }

        //calculate Area
        public override float Calc_Area()
        {
            double area = 0.5f * A * B;
            return (float)area;
        }

        public override float Calc_perimeter()
        {
            float c = MathF.Sqrt(MathF.Pow(A, 2) + MathF.Pow(B, 2));
            float area = A + B + c;
            return area;
        }

    }
}
