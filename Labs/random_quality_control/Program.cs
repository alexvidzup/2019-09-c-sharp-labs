using System;

namespace random_quality_control
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0, seven = 0, eight = 0, nine = 0, ten = 0;

            for (int i = 0; i < 10000; i++)
            {


                var randomNumber = new Random();
                var number = randomNumber.Next(1, 11);
                //Console.WriteLine(number);

                switch (number)
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                    case 4:
                        four++;
                        break;
                    case 5:
                        five++;
                        break;
                    case 6:
                        six++;
                        break;
                    case 7:
                        seven++;
                        break;
                    case 8:
                        eight++;
                        break;
                    case 9:
                        nine++;
                        break;
                    case 10:
                        ten++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"1: {one}, 2: {two}, 3: {three}, 4: {four}, 5: {five}, 6: {six}, 7: {seven}, 8: {eight}, 9: {nine}, 10: {ten}");

        }
    }
}
