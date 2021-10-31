using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Singer = { "김범수", "나얼", "박효신", "박정현", "이수","" };

            int MaxSinger = 5;
            /*         
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(Singer[i]);
            }
            */
            for (int i = 0; i <= MaxSinger; i++)
            {
                Console.WriteLine(Singer[i]);
            }
        }
    }
}
