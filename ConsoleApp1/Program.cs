using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // num 1
            /*      
           int[] A = new int[5];
           int[,] B = new int[3, 4];
           Random random = new Random();
           for (int i = 0; i < A.Length; i++)
           {
               Console.WriteLine("Вводите значения массива");
               A[i] = Convert.ToInt32(Console.ReadLine());
           }
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 4; j++)
               {
                   B[i, j] = random.Next(0,100) ;
               }
           }
           Console.WriteLine("Массив A:");
           foreach (var element in A)
           {
               Console.Write(element + " ");
           }
           Console.WriteLine();

           Console.WriteLine("Массив B:");
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 4; j++)
               {
                   Console.Write(B[i, j] + "\t");
               }
               Console.WriteLine();
           }
           int maxA = A[0];
           int minA = A[0];
           int maxB = B[0, 0];
           int minB = B[0, 0];

           foreach (var element in A)
           {
               if (element > maxA)
                   maxA = element;
               if (element < minA)
                   minA = element;
           }

           foreach (var element in B)
           {
               if (element > maxB)
                   maxB = element;
               if (element < minB)
                   minB = element;
           }

           Console.WriteLine($"Максимальный элемент в массиве A: {maxA}");
           Console.WriteLine($"Минимальный элемент в массиве A: {minA}");
           Console.WriteLine($"Максимальный элемент в массиве B: {maxB}");
           Console.WriteLine($"Минимальный элемент в массиве B: {minB}");

           int sumA = 0;
           int productA = 1;
           int sumB = 0;
           int productB = 1;

           foreach (var element in A)
           {
               sumA += element;
               productA *= element;
           }

           foreach (var element in B)
           {
               sumB += element;
               productB *= element;
           }

           Console.WriteLine($"Общая сумма элементов в массиве A: {sumA}");
           Console.WriteLine($"Общее произведение элементов в массиве A: {productA}");
           Console.WriteLine($"Общая сумма элементов в массиве B: {sumB}");
           Console.WriteLine($"Общее произведение элементов в массиве B: {productB}");

           int sumEvenA = 0;
           foreach (var element in A)
           {
               if (element % 2 == 0)
               {
                   sumEvenA += element;
               }
           }

           Console.WriteLine($"Сумма четных элементов в массиве A: {sumEvenA}");

           int sumColumnsB = 0;
           for (int j = 0; j < 4; j++)
           {
               if (j % 2 != 0)
               {
                   for (int i = 0; i < 3; i++)
                   {
                        sumColumnsB += B[i, j];
                   }
               }
           }
           Console.WriteLine($"Сумма нечетных столбцов в массиве B: {sumColumnsB}");
           */
            //num 2
            /*
            Random random = new Random();
            int[,] array = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101); 
                }
            }

            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minElement = array[0, 0];
            int maxElement = array[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] == minElement)
                    {
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] == maxElement)
                    {
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            int sum = 0;
            for (int i = Math.Min(minRow, maxRow); i <= Math.Max(minRow, maxRow); i++)
            {
                for (int j = Math.Min(minCol, maxCol); j <= Math.Max(minCol, maxCol); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine($"Минимальный элемент: {minElement}");
            Console.WriteLine($"Максимальный элемент: {maxElement}");
            Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");
        */
            //num 3
            /*
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Console.WriteLine("1.Шифрование, 2.Расшифрование");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("Введите строку для шифрования: ");
                string str = Console.ReadLine();
                Console.Write("Введите сдвиг: ");
                int shift = Convert.ToInt32(Console.ReadLine());
                char[] array = str.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (array[i] == alphabet[j])
                        {
                            int newIndex = (j + shift) % alphabet.Length;
                            array[i] = alphabet[newIndex];
                            break;
                        }
                    }
                }
                string s = new string(array);
                Console.WriteLine(s);
            }
            else if(input == 2)
            {
                Console.Write("Введите строку для расшифрования: ");
                string str = Console.ReadLine();
                Console.Write("Введите сдвиг: ");
                int shift = Convert.ToInt32(Console.ReadLine());
                char[] array = str.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (array[i] == alphabet[j])
                        {
                            int newIndex = (j - shift + alphabet.Length) % alphabet.Length;
                            array[i] = alphabet[newIndex];
                            break;
                        }
                    }
                }
                string s = new string(array);
                Console.WriteLine(s);
            }
            */
            //num 4
            /*
            int rows = 2;
            int cols = 2;
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            Random rand = new Random();
            Console.WriteLine("matrix1: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix1[i, j] = rand.Next(0, 9);
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("matrix2: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = rand.Next(0, 9);
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("1. Умножение матрицы на число, 2. Сложение матрицы, 3. Произведение матриц");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a == 1)
            {
                Console.WriteLine("введите число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("matrix1: ");
                for (int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        matrix1[i, j] *= b;
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                
            }
            if(a == 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix1[i, j] += matrix2[i, j];
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if(a == 3)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix1[i, j] *= matrix2[i, j];
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            */
            //num 5
            /*
            Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");
            string? str = Console.ReadLine();

            string[] arrayOfString = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0, num1 = 0;
            bool plus = true;
            for (int i = 0; i < arrayOfString.Length; i++)
            {
                if (double.TryParse(arrayOfString[i], out num1))
                {
                    if (plus)
                        result += num1;
                    else
                        result -= num1;
                }
                else
                {
                    if (arrayOfString[i] == "+")
                        plus = true;
                    else
                        plus = false;
                }
            }
            Console.WriteLine(result);
            */
            //num 6
            /*   
            string inputText = "today is a good day for walking. i will try to walk near the sea.";
            StringBuilder resultText = new StringBuilder();

            bool isSentenceStart = true;

            foreach (var el in inputText)
            {
                if (char.IsLetter(el))
                {
                    if (isSentenceStart)
                    {
                        resultText.Append(char.ToUpper(el)); 
                        isSentenceStart = false;
                    }
                    else resultText.Append(el);
                }
                else if (".!?".IndexOf(el) != -1)
                {
                    isSentenceStart = true;
                    resultText.Append(el);
                }
                else resultText.Append(el);
            }

            Console.WriteLine(resultText.ToString());
            */
            //num 7
            /*
            int count = 0;
            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();

            Console.WriteLine("Введите недопустимое слово:");
            string word = Console.ReadLine().ToLower();

            string text = EditText(str, word, count);

            Console.WriteLine("Измененный текст:");
            Console.WriteLine(text);
            */


        }
        static string EditText(string str, string word, int count)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string sanitizedWord = words[i].Trim(new char[] { ' ', '.', ',', '!', '?' });

                if (!string.IsNullOrWhiteSpace(sanitizedWord) && sanitizedWord.ToLower() == word)
                {
                    words[i] = new string('*', word.Length);
                    count++;
                }
            }
            Console.WriteLine($"Количество замен слова '{word}' на *: {count}");
            return string.Join(" ", words);
        }
    }
}