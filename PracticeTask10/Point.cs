using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask10
{
    public class Point
    {
        public int Pow { get; set; } // Степень числа
        public int Coeff { get; set; } // Коэффициент
        public Point Next; // Ссылка на следующий элемент
        public Point(int pow, int coeff)
        {
            this.Pow = pow;
            this.Coeff = coeff;
            Next = null;
        }
    }
}
