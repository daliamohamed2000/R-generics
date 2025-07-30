namespace R_generics
{
    class program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool flag;
            for (int i = 0; i < n - 1; i++)
            {
                flag = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag) break;
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            //Range<int> r1 = new Range<int>(1, 10);
            ////Range<int> r2 = new Range<int>(17, 10);
            //Console.WriteLine(r1.IsInRange(3));
            //Console.WriteLine(r1.IsInRange(11));
            //Console.WriteLine(r1.Lenght() + "\n");

            //Range<char> r3 = new Range<char>('a', 'd');
            //Console.WriteLine(r3.IsInRange('c'));
            //Console.WriteLine(r3.IsInRange('g'));
            //Console.WriteLine(r3.Lenght() + "\n");

            //Range<double> r4 = new Range<double>(2.5, 6.5);
            //Console.WriteLine(r4.IsInRange(3.76));
            //Console.WriteLine(r4.IsInRange(9.88));
            //Console.WriteLine(r4.Lenght() + "\n");
            #endregion
            #region Q2
            int[] arr = { 6, 7, 5, 3, 1, 2 };
            Console.WriteLine("Original array:");
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();
            BubbleSort(arr);
            Console.WriteLine("Sorted array:");
            foreach (int i in arr) Console.Write(i + " ");
            #endregion
        }
    }
}