namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter K : ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[k * 2];
            Random random = new Random();
            for (int i = 0; i < k * 2; i++)
            {
                arr[i] = random.Next(k, k * 4);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine(" ");
            for (int i = 0; i < k * 2; i++)
            {
                if (arr[i] % k == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}