using System;

namespace HomeTasks3
{
    class Program
    {
        public static void Main()
        {
            Console.Write("ДЗ №1");
            Task1();
            Console.Write("ДЗ №2");
            Task2();
            Console.Write("ДЗ №21");
            Task21();
            Console.Write("ДЗ №3");
            Task3();
            Console.Write("ДЗ №31");
            Task31();

        }

        #region Task1
        //——————————————————-Task1————————————————//
        public static void Task1() {
            Console.WriteLine("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(a));
            Console.WriteLine(Check(b));
            Console.WriteLine(Check(c));
        }

        public static int Check(int temp)
        {
            if (temp >= 0) temp = (int)Math.Pow(temp, 2);
            return temp;
        }
        //——————————————————-————————————————//
        #endregion

        #region Task2
        //——————————————————-Task2————————————————//
        public static void Task2() {
            int n = int.Parse(Console.ReadLine());
            n = 12;

            switch (n)
            {
                case 1: Console.WriteLine("31");
                    break;
                case 2: Console.WriteLine("28");
                    break;
                case 3: Console.WriteLine("31");
                    break;
                case 4: Console.WriteLine("30");
                    break;
                case 5: Console.WriteLine("31");
                    break;
                case 6: Console.WriteLine("30");
                    break;
                case 7: Console.WriteLine("31");
                    break;
                case 8: Console.WriteLine("31");
                    break;
                case 9: Console.WriteLine("30");
                    break;
                case 10: Console.WriteLine("30");
                    break;
                case 11: Console.WriteLine("30");
                    break;
                case 12: Console.WriteLine("31");
                    break;
            }
        }
        public static void Task21()
        {

            Console.Write("Вводите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Вводите год: ");
            int year = int.Parse(Console.ReadLine());
            DateTime dt1 = new DateTime(year, month, 1);
            DateTime dt2 = dt1.AddMonths(1);
            int days = (dt2 - dt1).Days;
            Console.Write("количество дней в месяце: " + days);
            Console.ReadLine();
        }
        //——————————————————-————————————————//
        #endregion

        #region Task3
        //——————————————————-Task3————————————————//
        public static void Task3()
        {
            double a, b, c;
            Console.Write("Введите вещественное число a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число c = ");
            c = double.Parse(Console.ReadLine());
            if ((b > a) && (a > c))
            {

                Console.WriteLine("{0} > {1} > {2} - {3}", b, a, c, ((b > a) && (a > c)));
            }
            else if ((a < b) && (b < c))
            {

                Console.WriteLine("{0} < {1} < {2} - {3}", a, b, c, (a < b) && (b < c));
            }
            else
            {
                Console.WriteLine("Нет правильных выполнений неравенств");
            }
            Console.ReadLine();
        }

        public static void Task31()
        {
            double a, b, c;
            Console.Write("Введите вещественное число a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число c = ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("а) a < b < c = {0} > {1} > {2} - {3}", b, a, c, ((b > a) && (a > c)));
            Console.WriteLine("б) b > a > c =  {0} < {1} < {2} - {3}", a, b, c, (a < b) && (b < c));
           
            Console.ReadLine();
        }
        //——————————————————-————————————————//
        #endregion
    }
}
