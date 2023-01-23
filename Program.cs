namespace Data_Structures_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            /* string[] word = { "Ajay", "Chandra", "Awesome" };
             string item = Console.ReadLine();
             int final = Binary_Search.Search(word, item);
             if (final==-1)
             {
                 Console.WriteLine("Item not found");
             }
             else 
             {
                 Console.WriteLine("Item found "+final);
             }*/
            //string[] word = { "Ajay", "Chandra", "Awesome" };
            //Insertion_Sort.Sorting(word);
            //Console.WriteLine("Sorted");
            //for(int i=0;i<word.Length;i++)
            //{
            //    Console.WriteLine(word[i]+" ");
            //}
            int[] arr = { 10, 23, 88, 14, 222 };
            Bubble_Sort.bubbleSort(arr);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
    }
}