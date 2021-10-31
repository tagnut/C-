using System;

namespace Quiz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MarvelHero = { "아이언맨", "토르", "헐크" };
            int MaxMarvelHero = 3;
            for(int i=0; i<MaxMarvelHero; i++)
            {
                Console.WriteLine(MarvelHero[i]);
            }

        }
    }
}
