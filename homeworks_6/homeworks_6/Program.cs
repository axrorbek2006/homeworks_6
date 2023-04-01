namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[16];
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Array: ");
            for (int i = 0; i < 15; i++)
            {
                arr[i] = random.Next(1, 15);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            if (arr.Contains(n))
            {
                Console.WriteLine($"{n} is in the array.");
            }
            else
            {
                Console.WriteLine($"{n} is not in the array.");
            }

        }
    }
}