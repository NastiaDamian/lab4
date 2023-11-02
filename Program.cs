using System;

class Program
{
    static void Main()
    {
        //Завдання 1
        Console.Write("Введiть розмiр масиву ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine($"Сума всiх чисел у масивi: {sum}");

        // Завдання 2 
        Console.Write(" Введiть розмiр масиву: ");
        int k = int.Parse(Console.ReadLine());

        int[] knumbers = new int[n];

        for (int i = 0; i < k; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            knumbers[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = IsPalindrome(knumbers);

        if (isPalindrome)
        {
            Console.WriteLine("Масив є палiндромом");
        }
        else
        {
            Console.WriteLine("Масив не є палiндромом");
        }

        static bool IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            {
                if (arr[left] != arr[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        // Завдання 3

        Console.Write("Введiть розмiр масиву ");
        int p = int.Parse(Console.ReadLine());

        int[] pnumbers = new int[p];

        for (int i = 0; i < p; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            pnumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Парними є такі числа у масиві ");

        for (int i = 0; i < p; i++)
        {
            if (pnumbers[i] % 2 == 0)
            {
                Console.WriteLine(pnumbers[i]);
            }
        }
        // Завдання 4 
        Console.Write(" Введiть розмiр масиву ");
        int a = int.Parse(Console.ReadLine());

        int[] anumbers = new int[a];

        for (int i = 0; i < a; i++)
        {
            Console.Write($"Введiть додатнє число {i + 1}: ");
            anumbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOfPositiveNumbers = SumPositiveNumbers(anumbers);
        Console.WriteLine($"Сума всiх додатних чисел у масивi {sumOfPositiveNumbers}");


        static int SumPositiveNumbers(int[] arr)
        {
            int sum = 0;

            foreach (int anumber in arr)
            {
                if (anumber > 0)
                {
                    sum += anumber;
                }
            }

            return sum;
        }
        // Завдання 5 

        Console.Write("Введiть розмiр масиву: ");
        int l = int.Parse(Console.ReadLine());

        int[] lnumbers = new int[l];

        for (int i = 0; i < l; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            pnumbers[i] = int.Parse(Console.ReadLine());
        }

        int smallestIndex = FindSmallestIndex(numbers);
        Console.WriteLine($"Найменшим iндексом елемента у масивi {smallestIndex}");

        static int FindSmallestIndex(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;

            }

            int smallestIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[smallestIndex])
                {
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
        //Завдання 6 
        Console.Write(" Введiть розмiр масиву: ");
        int b = int.Parse(Console.ReadLine());

        int[] bnumbers = new int[b];

        for (int i = 0; i < b; i++)
        {
            Console.Write($"Введiть вiд'ємнє число {i + 1}: ");
            anumbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOfNegativeNumbers = 0;

        foreach (int bnumber in bnumbers)
        {
            if (bnumber < 0)
            {
                sumOfNegativeNumbers += bnumber;
            }
        }
        Console.WriteLine($"Сума всiх вiд'ємних чисел у масивi: {sumOfNegativeNumbers}");


        //Багатовимірні масиви
        //Завдання 1
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            Console.WriteLine("Матриця не є квадратною");
        }
        else
        {
            int suma = 0;
            for (int i = 0; i < rows; i++)
            {
                suma += matrix[i, i];
            }
            Console.WriteLine("Сума елементів по головній діагоналі: " + suma);
        }

        //Завдання 2 
        int[,] amatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Введiть номер стовпця для обчислення добутку");
        int columnToMultiply = Convert.ToInt32(Console.ReadLine());

        int columnProduct = CalculateColumnProduct(amatrix, columnToMultiply - 1);

        if (columnProduct != -1)
        {
            Console.WriteLine("Добуток елементiв " + columnToMultiply + ": " + columnProduct);
        }
        else
        {
            Console.WriteLine("Було введено некоректний номер стовпця");
        }

        static int CalculateColumnProduct(int[,] amatrix, int columnIndex)
        {
            if (columnIndex < 0 || columnIndex >= amatrix.GetLength(1))
            {
                return -1;
            }

            int product = 1;
            for (int i = 0; i < amatrix.GetLength(0); i++)
            {
                product *= amatrix[i, columnIndex];
            }
            return product;
        }

        // Завдання 3
        int[,] bmatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine(" Початкова матриця:");
        PrintMatrix(bmatrix);

        int[,] rotatedMatrix = RotateMatrixCounterClockwise(bmatrix);

        Console.WriteLine("Матриця пiсля обертання на 90 градусів проти годинникової стрілки:");
        PrintMatrix(rotatedMatrix);


        static int[,] RotateMatrixCounterClockwise(int[,] bmatrix)
        {
            int n = bmatrix.GetLength(0);
            int[,] rotatedMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedMatrix[n - 1 - j, i] = bmatrix[i, j];
                }
            }

            return rotatedMatrix;
        }

        static void PrintMatrix(int[,] bmatrix)
        {
            int n = bmatrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(bmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

