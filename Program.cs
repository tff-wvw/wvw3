using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static (int min, int max) InputMinMax()
        {
            Console.WriteLine("Сколько чисел будет в вашем массиве? ");
            int arrayLength;
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
            {
                Console.WriteLine("Ошибка, введите число");
            }
            int[] numbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                while (true)
                {
                    Console.Write($"Введите ваше число номер {i + 1}: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out numbers[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, введите число");
                    }
                }
            }
            int min = numbers[0];
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            return (min, max);
        }
        static int GetIntegerInput(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(),out number) && number > 0)
                {
                    return number;
                }
                Console.WriteLine("Ошибка");
            }
        }
        static int[] GetFibonacci(int n)
        {
            if (n <= 0) return new int[0];

            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            if (n > 1)
            {
                fibonacci[1] = 1;
            }
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
            }
            return fibonacci;
        }
        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }
        static bool Task5(string str1, string str2)
        {
            return string.Equals(str1, str2);
        }
        static int Task6(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Task7(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j <n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                if (maxIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[maxIndex];
                    arr[maxIndex] = temp;
                }
            }
        }
        static double Task8(double num1, double num2, char operation)
        {
            double result1 = 0;

            switch (operation)
            {
                case '+':
                    result1 = num1 + num2;
                    break;
                case '-':
                    result1 = num1 - num2;
                    break;
                case '*':
                    result1 = num1 * num2;
                    break;
                case '/':
                    result1 = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }
            return result1;
        }
        static bool Task9(int number9)
        {
            if (number9 <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number9); i++)
            {
                if (number9 % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int Task10(int number10)
        {
            int sum10 = 0;
            while (number10 != 0)
            {
                sum10 += number10 % 10;
                number10 /= 10;
            }
            return sum10;
        }
        static int Task11(int a)
        {
            return a * 9 / 5 + 32;
        }
        static void Main()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("\nВыберите действие: ");
                Console.WriteLine("1. Сумма четных и нечетных чисел");
                Console.WriteLine("2. Поиск максимального и минимального значений");
                Console.WriteLine("3. Числа фибоначчи");
                Console.WriteLine("4. Обратный порядок массивов");
                Console.WriteLine("5. Сравнение строк");
                Console.WriteLine("6. Сумма чисел от 1 до N");
                Console.WriteLine("7. Сортировка массива");
                Console.WriteLine("8. Калькулятор");
                Console.WriteLine("9. Проверка на простое число");
                Console.WriteLine("10. Сумма цифр числа");
                Console.WriteLine("11. Конвертация температуры");
                Console.WriteLine("66. Выход из программы");
                Console.WriteLine("Введите номер действия: ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        int evenSum = 0;
                        int oddSum = 0;
                        int count = 0;
                        while (count < 10)
                        {
                            Console.Write($"Введите 10 целых чисел, это {count + 1}: ");
                            string input1 = Console.ReadLine();
                            int number1;
                            if (int.TryParse(input1, out number1))
                            {
                                if (number1 % 2 == 0)
                                {
                                    evenSum += number1;
                                }
                                else
                                {
                                    oddSum += number1;
                                }
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректное число!");
                            }
                            Console.WriteLine($"Сумма четных чисел: {evenSum}");
                            Console.WriteLine($"Сумма нечетных чисел: {oddSum}");
                        }
                        Thread.Sleep(2500);
                        break;

                    case "2":
                        var result = InputMinMax();
                        Console.WriteLine($"Минимальное число - {result.min}");
                        Console.WriteLine($"Максимально число - {result.max}");
                        Thread.Sleep(2500);
                        break;

                        case "3":
                        int n = GetIntegerInput("Введите количество чисел фибоначчи - ");
                        int[] fibonacciNumbers = GetFibonacci(n);
                        Console.WriteLine($"Первые {n} чисел фибоначчи - {string.Join(", ", fibonacciNumbers)}");
                        Thread.Sleep(2500);
                        break;

                        case "4":
                        Console.WriteLine("Введите элементы массива через пробел: ");
                        string input = Console.ReadLine();
                        string[] inputArray = input.Split(' ');
                        int[] array = new int[inputArray.Length];
                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            array[i] = Convert.ToInt32(inputArray[i]);
                        }
                        int[] reversedArray = ReverseArray(array);
                        Console.WriteLine("Исходный массив - ");
                            Console.WriteLine(string.Join(" ", array));
                        Console.WriteLine("Массив с числами в обратном порядке - ");
                            Console.WriteLine(string.Join(" ", reversedArray));
                        Thread.Sleep(2500);
                        break;

                        case "5":
                        Console.WriteLine("Введите первую строку - ");
                        string str1 = Console.ReadLine();

                        Console.WriteLine("Введите вторую строку - ");
                        string str2 = Console.ReadLine();

                        bool result5 = Task5(str1, str2);
                        if (result5)
                        {
                            Console.WriteLine("Строки равны.");
                        }
                        else
                        {
                            Console.WriteLine("Строки не равны");
                        }
                        Thread.Sleep(2500);
                        break;
                    case "6":
                        Console.WriteLine("Введите число - ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int sum = Task6(number);
                        Console.WriteLine($"Сумма всех чисел от 1 до {number} равна {sum}");
                        Thread.Sleep(2500);
                        break;
                    case "7":
                        Console.WriteLine("Введите элементы массива через пробел - ");
                        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                        Task7(arr);

                        Console.WriteLine("Отсортированный массив - ");
                        foreach (int num in arr)
                        {
                            Console.Write(num + " ");
                        }
                        Thread.Sleep(2500);
                        break;
                    case "8":
                        Console.WriteLine("Введите число 1");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число 2");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите операцию (+, -, *, /");
                        char operation = (char)Console.Read();

                        double result1 = Task8(num1, num2, operation);
                        Console.WriteLine($"Результат {num1} {operation} {num2} = {result1}");
                        Thread.Sleep(2500);
                        break;
                    case "9":
                        Console.WriteLine("Введите число - ");
                        int number9 = int.Parse(Console.ReadLine());

                        bool isPrime = Task9(number9);
                        if (isPrime)
                        {
                            Console.WriteLine("Число " + number9 + " Является простым");
                        }
                        else
                        {
                            Console.WriteLine("Число " + number9 + " Не является простым");
                        }
                        Thread.Sleep(2500);
                        break;
                    case "10":
                        Console.WriteLine("Введите целое число - ");
                        int number10 = Convert.ToInt32(Console.ReadLine());
                        int sum10 = Task10(number10);
                        Console.WriteLine($"Сумма цифр числа {number10} равна {sum10}");
                        Thread.Sleep(2500);
                        break;
                    case "11":
                        Console.WriteLine("Введите температуру в фаренгейтах: ");

                        int a;
                        while (!int.TryParse(Console.ReadLine(), out a))
                        {

                            Console.WriteLine("Введите корректные данные! ");
                        }


                        int Celsii = Task11(a);
                        Console.WriteLine($"Температура в цельсиях:{Celsii}");

                        Thread.Sleep(2500);
                        break;


                    case "66":
                        continueRunning = false;
                        Console.WriteLine("Выход из программы");
                        break;

                }
            }
        }
    }
}
