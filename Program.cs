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
                    int[] arr = { 2, 4, 6, 8, 10 };

                    MyArray arrayObj = new MyArray(arr);

             
                    Console.WriteLine("Elems less 5: " + arrayObj.Less(5));
                    Console.WriteLine("Elems greater 5: " + arrayObj.Greater(5));
                    break;
                case 1:
                    int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                    MyArray arrayObj1 = new MyArray(arr1);

                    Console.WriteLine("Even:");
                    arrayObj1.ShowEven();

                    Console.WriteLine("\nOdd:");
                    arrayObj1.ShowOdd();
                    break;
                case 2:
                    int[] arr2 = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10 };

                    MyArray arrayObj2 = new MyArray(arr2);

                    
                    Console.WriteLine("Uniq: " + arrayObj2.CountDistinct());
                    Console.WriteLine("Eqals 6: " + arrayObj2.EqualToValue(6));
                break;
            }
        }
    }
}
