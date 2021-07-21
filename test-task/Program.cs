using System;
using System.Collections.Generic;
using System.Linq;

namespace test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentenceArr = { "Он заплатил двадцать миллионов за три таких автомобиля", "Она купила квартиру за десять миллионов сто пятьдесят тысяч рублей", "Мама купила мне путевку за десять тысяч рублей в Севастополь, там сегодня сорок градусов тепла" };

            Logic convertToNum = new Logic();

            for (int i = 0; i < sentenceArr.Length; i++)
            {
                Console.WriteLine(sentenceArr[i]);
                var res = convertToNum.FindNumbers(sentenceArr[i]);
                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}
