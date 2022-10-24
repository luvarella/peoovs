using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Retangulo
    {
        private double b, h;
        public void SetBase(double v)
        {
            if (v > 0) b = v;
        }
        public void SetAltura(double v)
        {
            if (v > 0) h = v;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(b * b + h * h);
        }
    }
}
