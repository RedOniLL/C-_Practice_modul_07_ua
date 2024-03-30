using System;


namespace C__Practice_modul_07_ua
{
   public class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        private int[] elements;

        public MyArray(int[] arr)
        {
            elements = arr;
        }

        public void Show()
        {
            Console.WriteLine("Elems of array:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show(); 
            Console.WriteLine("Info: " + info);
        }
        public int Max()
        {
            int max = elements[0];
            foreach (var element in elements)
            {
                if (element > max)
                    max = element;
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            foreach (var element in elements)
            {
                if (element < min)
                    min = element;
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return (float)sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var element in elements)
            {
                if (element == valueToSearch)
                    return true;
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(elements);
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element < valueToCompare)
                    count++;
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element > valueToCompare)
                    count++;
            }
            return count;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even:");
            foreach (var element in elements)
            {
                if (element % 2 == 0)
                    Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd:");
            foreach (var element in elements)
            {
                if (element % 2 != 0)
                    Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int distinctCount = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                bool isDistinct = true;
                for (int j = 0; j < i; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        isDistinct = false;
                        break;
                    }
                }
                if (isDistinct)
                    distinctCount++;
            }
            return distinctCount;
        }

       
        public int EqualToValue(int valueToCompare)
        {
            int equalCount = 0;
            foreach (var element in elements)
            {
                if (element == valueToCompare)
                    equalCount++;
            }
            return equalCount;
        }
    }

}
