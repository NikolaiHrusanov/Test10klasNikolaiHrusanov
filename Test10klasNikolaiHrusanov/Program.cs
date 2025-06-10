namespace Test10klasNikolaiHrusanov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 36, 12, 11, 23, 5, 8, 1, 7 };

            Console.WriteLine("Unsorted array:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("Numbers in array");
            Console.WriteLine(array.Length);
        }


        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;


            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

