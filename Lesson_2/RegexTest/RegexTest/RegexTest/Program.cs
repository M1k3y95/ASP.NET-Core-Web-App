using System;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " Предложение  один Теперь   предложение  два Предложение   три ";

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string res = regex.Replace(str, " ");

            Console.WriteLine(res);

            regex = new Regex(@"^\s|\s$", options);
            res = regex.Replace(res, "");

            Console.WriteLine(res);

            regex = new Regex(@"\s(?=[А-Я])", options);
            res = regex.Replace(res, ". ");

            Console.WriteLine(res);
        }
    }
}
