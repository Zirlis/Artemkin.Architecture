using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
        string userText;
        int userNumber;

        do
        {
            Console.WriteLine("Пожалуйста, введите целое число");
            userText = Console.ReadLine();

        } while (!Int32.TryParse(userText, out userNumber));
        
        int factorial = 1; 
        int sum = 0;
        int maxEvenNum = 0;
        for (int i = 1; i <= userNumber; i++)
        {
            factorial = factorial * i;
            sum = sum + i;
            if (i % 2 == 0 && i != userNumber)
            {
                maxEvenNum = i;
            }
        }
        Console.WriteLine("Факториал равен " + factorial); 
        Console.WriteLine("Сумма чисел от 1 до N равна " + sum);
        if (maxEvenNum > 0)
        {
            Console.WriteLine("Максимальное четное число меньше N равно " + maxEvenNum);
        }
        Console.ReadLine();
    }
}