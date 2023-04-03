namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Random random = new Random();
            Console.Write("Massiv : ");
            for (int i = 0; i<7; i++)
            {
                arr[i] = random.Next(1,7);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.Write("tartiblangan massiv : ");
            Array.Sort(arr);
            for(int i = 0; i<7; i++)
            {
                Console.Write(arr[i]+" ");
            }  
        }
    }
}