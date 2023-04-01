namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[6];
            Console.Write("Array: ");
            int sum = 0, multiple = 1;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = random.Next(1, 8);
                Console.Write(arr[i] + " ");
                sum += arr[i];
                multiple *= arr[i];
            }
            Console.WriteLine();
            Console.WriteLine($"massivni yigindisi : {sum}");
            Console.WriteLine("massivni yigindisi : "+multiple);
            
        }
    }
}