namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n, k, l;
            Console.Write(" enter n : ");
            n = Convert.ToInt32( Console.ReadLine());
            Console.Write(" enter k : ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write(" enter l : ");
            l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write(" massiv :");
            for (int i = 0; i<n; i++)
            {
                arr[i] = random.Next(1, 15);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write(" massiv :");
            int num = arr[k];
            arr[k] = arr[l];
            arr[l] = num;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}