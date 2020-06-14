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
        public OneList(string[] lines) // Создание списка из массива строк
        {
            bool is_correct = true;
            for (int i = 0; i < lines.Length && is_correct; i++)
            {
                string[] line = string.Join("", lines[i].Split(',')).Split(' '); // Удаление запятых и разбиение строки на подстроки, разделенные пробелом
                if (line.Length == 2) // В строке должно быть два числа
                {
                    int pow, coeff;
                    if (int.TryParse(line[0], out pow) & int.TryParse(line[1], out coeff)) // В строке два целых числа
                    {
                        if (pow >= 0 && pow <= 100) // Степень от 0 до 100
                        {
                            if (coeff != 0) // Если ненулевой коэффициент, то добавление в список
                            {
                                Point point = new Point(pow, coeff); // Слздание элемента списка
                                point.Next = list;
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
            if (!is_correct) // Если некорректный ввод
            {
                // Обнуление
                list = null;
                Length = 0;
            }
        }
        public string Show() // Вывод списка
        {
            if (list != null) // Если список не пустой
            {
                string output = "Список:" + "\n" + "Степень    коэффициент" + "\n";
                Point current_point = list;
                do
                {
                    output += string.Format("{0, -12} {1, -25}", current_point.Pow.ToString(), current_point.Coeff.ToString()) + "\n";
                    current_point = current_point.Next;
                } while (current_point != null);
                return output;
            }
            else return string.Empty;
        }
        public double Sum_Calculation(int x) // Сумма полинома
        {
            double sum = 0;
            Point current_point = list; // Ссылка на первый элемент
            for(int i = 1; i <= Length; i++)
            {
                sum += Math.Pow(x, current_point.Pow) * current_point.Coeff; // К сумме прибавляется х в степени Pow текущего элемента, умноженное на Coeff текущего элемента
                current_point = current_point.Next; // Прохождение по списку
            }
            return sum;
        }
    }
}
