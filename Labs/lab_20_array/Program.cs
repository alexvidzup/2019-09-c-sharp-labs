using System;

namespace lab_20_array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1D
            int[] array01 = new int[10]; // size 10
            int[] arrayLiteral01 = new int[] { 1, 2, 3, 4, 5 };
            string[] stringLiteral = new string[] { "one", "two", "three" };

            // 2D 
            /*
            int[,] Array2D = new int[10, 10];
            // put data in
            for(int i = 0; i <10; i++)
            {
                for (int j = 0; j <10; j++)
                {
                    Array2D[i, j] = (i * j) * (i * j);
                }
            }

            // get data out
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(Array2D[i, j] + " ");

                }
                Console.WriteLine("\n");
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += Array2D[i, j];

                }
                
            }


            
            Console.WriteLine(sum                      */
            // 3D 
            int[,,] Cube3D = new int[10, 10, 10];
            int sum3D = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int n = 0; n < 10; n++)
                        Cube3D[i, j, n] = i * i * j * j * n * n;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int n = 0; n < 10; n++)
                        sum3D += Cube3D[i, j, n];
                }
            }
            Console.WriteLine(sum3D);



            // jagged is an array of arrays which have indistinct lengths
            int[][] myJaggedArray = new int[10][];   // array of 10 arrays but individual lengths not defined

            myJaggedArray[0] = new int[5];
            Console.WriteLine(myJaggedArray[0].Length); // prints out 5
            myJaggedArray[1] = new int[] { 1, 2, 3 };
        }
    }
}
