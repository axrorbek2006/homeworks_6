namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            Console.Write("Array: ");
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                arr[i] = random.Next(1, 15);
               Console.Write(arr[i] + " ");
                if (arr[i] % 2 != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine();
            int summa = 0 , summa2 = 0;
            if (sum > 0)
            {
                for (int i = 0; i <=9; i++)
                {
                    if (arr[i]%2 == 0)
                    {
                        summa += arr[i];
                    }
                    else
                    {
                        Console.WriteLine("yigindi : " + summa);
                        break;
                    }
                }              
            }
            else
            {
                for (int i = 1; i <=8; i++)
                {                   
                        summa2 += arr[i];                   
                }
                Console.WriteLine("t yigindi : "+summa2);               
            }            
        }
    }
}