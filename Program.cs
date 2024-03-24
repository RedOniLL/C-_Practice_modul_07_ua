namespace C__Practice_modul_07_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");
            int c = int.Parse(Console.ReadLine()); 

            switch (c)
            {
                case 0:
                    int[] arr = { 1, 2, 3, 4, 5 };
                    MyArray array = new MyArray(arr);

                  
                    Console.WriteLine(" Show():");
                    array.Show();

                    
                    Console.WriteLine("\n Show(string info):");
                    array.Show("My info message.");
                    break;
                case 1:
                    int[] arr2 = { 1, 2, 3, 4, 5 };
                    MyArray array2 = new MyArray(arr2);

                    Console.WriteLine("Maximum: " + array2.Max());
                    Console.WriteLine("Minimum: " + array2.Min());
                    Console.WriteLine("Average: " + array2.Avg());
                    Console.WriteLine("Contains 5: " + array2.Search(5));
                    Console.WriteLine("Contains 10: " + array2.Search(10));
                    break;
                case 2:
                    int[] arr3 = { 9, 3, 7, 1, 5 };

                    MyArray arrayObj = new MyArray(arr3);

                    
                    Console.WriteLine("Array before sorting:");
                    arrayObj.Show();

                    Console.WriteLine("\nArray after sorting in ascending order:");
                    arrayObj.SortAsc();
                    arrayObj.Show();

                    Console.WriteLine("\nArray after sorting in descending order:");
                    arrayObj.SortDesc();
                    arrayObj.Show();

                    Console.WriteLine("\nArray after sorting in ascending order using SortByParam:");
                    arrayObj.SortByParam(true);
                    arrayObj.Show();

                    Console.WriteLine("\nArray after sorting in descending order using SortByParam:");
                    arrayObj.SortByParam(false);
                    arrayObj.Show();
                    break;
            }
        }
    }
}
