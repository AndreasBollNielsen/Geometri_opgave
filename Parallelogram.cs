using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    class Parallelogram : Square
    {
        private float angle;
        private float b;

        public float B
        {
            get { return b; }
            set { b = value; }
        }

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Parallelogram(float a,float b,float angle) :base(a)
        {
            this.A = a;
            this.B = b;
            this.Angle = angle;
        }

        //calculate area
        public override float Calc_Area()
        {
            float rad = angle * MathF.PI / 180;
            double area = A * B * Math.Sin(rad);
            return (float)area;
        }

        public override float Calc_perimeter()
        {
            float perimeter = 2 * (A + B);
            return perimeter;
        }
    }
}
