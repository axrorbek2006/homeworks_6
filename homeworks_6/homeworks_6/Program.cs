namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter K : ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[k * 2];
            Random random = new Random();
            Console.Write(" massiv :  ");
            for (int i = 0; i < k * 2; i++)
            {
                arr[i] = random.Next(k, k * 4);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine(" ");
            Console.Write($"{k} ga karrali sonlar : ");
            for (int i = 0; i < k * 2; i++)
            {
                if (arr[i] % k == 0)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
        }
    }
}