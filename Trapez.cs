using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_opgave
{
    class Trapez : Square
    {
        private float b;
        private float c;
        private float d;


        public float D
        {
            get { return d; }
            set { d = value; }
        }

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


        public Trapez(float _a, float _b, float _c, float _d) : base(_a)
        {
            this.A = _a;
            this.B = _b;
            this.C = _c;
            this.d = _d;
        }

        public override float Calc_Area()
        {
            //calculate height
            float s = (A + B - C + D) / 2;
            double h = 2 / (A - C) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - D));
           
            float area = 0.5f * (A + C) * (float)h;
            return area;
        }

    }
}
