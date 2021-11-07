using System;

namespace _20211107_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            Console.WriteLine("당신의 차의 연식은?");
            result = Console.ReadLine();
            //swtich 예제
            switch (result)
            {
                case "2016":
                    Console.WriteLine("운행가능합니다.");
                    break;
                case "2017":
                    Console.WriteLine("운행가능합니다.");
                    break;
                case "2018":
                    Console.WriteLine("운행가능합니다.");
                    break;
                case "2019":
                    Console.WriteLine("운행가능합니다.");
                    break;
                case "2020":
                    Console.WriteLine("운행가능합니다.");
                    break;
                default:
                    Console.WriteLine("버리세요.");
                    break;

            }
        }
    }
}
