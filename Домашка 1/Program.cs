namespace Домашка_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Figure_1;
            string Figure_2;
            string Operation;
            double Result;
            string Restart;
            bool Rest = true;

            while (Rest)
            {
                Console.Write("Введите число: ");
                Figure_1 = Console.ReadLine();
                double Fig_1 = Convert.ToDouble(Figure_1);
                Console.Clear();

                Console.WriteLine("Введите номер необходимой операции:");
                Console.WriteLine("Сложение: 1");
                Console.WriteLine("Возведение в квадрат: 2");
                Console.WriteLine("Деление второго числа на первое: 3");
                Console.WriteLine("Нахождение синуса: 4");
                Console.WriteLine("Нахождение косинуса: 5");
                Console.WriteLine("Возведение в степень: 6");
                Console.WriteLine("Нахождение натурального логарифма: 7");
                Console.WriteLine("Нахождение десятичного логарифма: 8");
                Console.WriteLine("Нахождение логарифма: 9");
                Operation = Console.ReadLine();
                Console.Clear();

                if (Operation == "1")
                {
                    Console.Write("Введите второе число: ");
                    Figure_2 = Console.ReadLine();
                    Console.Clear();
                    double Fig_2 = Convert.ToDouble(Figure_2);
                    Console.WriteLine($"Результат вычислений: {Fig_1} + {Fig_2} = {Result = Fig_1 + Fig_2}");
                }
                if (Operation == "2")
                    Console.WriteLine($"{Fig_1} в квадрате = {Result = Fig_1 * Fig_1}");
                if (Operation == "3")
                {
                    Console.Write("Введите второе число: ");
                    Figure_2 = Console.ReadLine();
                    Console.Clear();
                    double Fig_2 = Convert.ToDouble(Figure_2);
                    Console.WriteLine($"Результат вычислений: {Fig_2} / {Fig_1} = {Result = Fig_2 / Fig_1}");
                }
                if (Operation == "4")
                    Console.WriteLine($"Результат вычислений: sin ({Fig_1}) = {Result = Math.Sin(Fig_1)}");
                if (Operation == "5")
                    Console.WriteLine($"Результат вычислений: cos ({Fig_1}) = {Result = Math.Cos(Fig_1)}");
                if (Operation == "6")
                {
                    Console.Write("Введите степень: ");
                    Figure_2 = Console.ReadLine();
                    Console.Clear();
                    double Fig_2 = Convert.ToDouble(Figure_2);
                    Console.WriteLine($"Результат вычислений: {Fig_1} в степени {Fig_2} = {Result = Math.Pow(Fig_1, Fig_2)}");
                }
                if (Operation == "7")
                    Console.WriteLine($"Результат вычислений: ln ({Fig_1}) = {Result = Math.Log(Fig_1)}");
                if (Operation == "8")
                    Console.WriteLine($"Результат вычислений: log10 ({Fig_1}) = {Result = Math.Log10(Fig_1)}");
                if (Operation == "9")
                {
                    Console.Write("Введите основание логарифма: ");
                    Figure_2 = Console.ReadLine();
                    Console.Clear();
                    double Fig_2 = Convert.ToDouble(Figure_2);
                    Console.WriteLine($"Результат вычислений: log{Fig_2} ({Fig_1}) = {Result = Math.Log(Fig_1, Fig_2)}");
                }

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Выполнить еще одну операцию?");
                Console.WriteLine("Да: 1");
                Console.WriteLine("Нет: 2");
                Restart = Console.ReadLine();
                if (Restart == "1")
                {
                    Rest = true;
                    Console.WriteLine("----------------------------------------------");
                    Console.Clear();
                }
                else
                {
                    Rest = false;
                    Console.Clear();
                }
            }
        }
    }
}