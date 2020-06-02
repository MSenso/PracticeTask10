using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask10
{
    public class OneList
    {
        Point list = null;
        public int Length { get; private set; } = 0;
        public OneList(string[] lines)
        {
            bool is_correct = true;
            if (lines.Length > 0)
            {
                for (int i = 0; i < lines.Length && is_correct; i++)
                {
                    string[] line = string.Join("", lines[i].Split(',')).Split(' ');
                    if (line.Length == 2)
                    {
                        int pow, coeff;
                        if (int.TryParse(line[0], out pow) && int.TryParse(line[1], out coeff))
                        {
                            if (pow >= 0 && pow <= 100)
                            {
                                if (coeff != 0)
                                {
                                    Point point = new Point(pow, coeff);
                                    Add(point, list);
                                    list = point;
                                    Length++;
                                }
                            }
                            else is_correct = false;
                        }
                        else is_correct = false;
                    }
                    else is_correct = false;
                }
                if (!is_correct)
                {
                    list = null;
                    Length = 0;
                }
            }
        }
        void Add(Point base_point, Point derived_point)
        {
            if (base_point != null)
            {
                base_point.Next = derived_point;
            }
        }
        public string Show()
        {
            string output = "Список:" + "\n" + "Степень    коэффициент" + "\n";
            Point current_point = list;
            do
            {
                output += string.Format("{0, -12} {1, -25}",  current_point.Pow.ToString(), current_point.Coeff.ToString()) + "\n";
                current_point = current_point.Next;
            } while (current_point != null);
            return output;
        }
        public double Sum_Calculation(int x)
        {
            double sum = 0;
            Point current_point = list;
            for(int i = 1; i <= Length; i++)
            {
                sum += Math.Pow(x, current_point.Pow) * current_point.Coeff;
                current_point = current_point.Next;
            }
            return sum;
        }
    }
}
