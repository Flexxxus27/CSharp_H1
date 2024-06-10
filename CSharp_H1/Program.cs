namespace CSharp_H1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1\n");
            Console.Write("Введите сторону A -> ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Введите сторону B -> ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону C -> ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(c > a || c > b)
            {
                throw new Exception("В прямоугольнике нельзя разместить квадрат со стороной C = " + c);
            }else
            {
                int count = (a / c) * (b / c);
                Console.WriteLine("В прямоугольнике AB поместится " +  count + " квадрата(ов).");
                double SEmpty = a * b - ((c * c) * count);
                Console.WriteLine("Не занятая площадь -> " +  SEmpty + "\n");
            }

            Console.WriteLine("Задача 2\n");

            double S = 10000;
            Console.Write("Введите процент -> ");
            double P = Convert.ToDouble(Console.ReadLine());
            if (P > 25 || P < 0)
            {
                throw new Exception("Процент не может быть меньше 0 и больше 25!");
            }
            else
            {
                int Month = 0;
                while (S <= 11000)
                {
                    double p1 = S / 100 * P;
                    S += p1;
                    Month++;
                }
                Console.WriteLine("За " + Month + " месяц(-ев) вклад привысил 11000р");
                Console.WriteLine("Текущий размер вклада " + S + "р\n");

                
            }
            Console.WriteLine("Задача 3\n");

                int A = 3, B = 7;
                for(int i = A; i <= B; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine("\nЗадача 4.\n");

            Console.Write("Введите число -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num < 0)
            {
                throw new Exception("Число не может быть меньше 0!");
            }else
            {
                int reversNum = 0;
                while(num > 0)
                {
                    reversNum = reversNum * 10 + num % 10;
                    num /= 10;
                }
                Console.WriteLine("Число наоборот -> " + reversNum);
            }

        }
    }
}
