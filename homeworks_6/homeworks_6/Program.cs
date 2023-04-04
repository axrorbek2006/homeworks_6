namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[][] arr = new int[random.Next(3, 6)][];

            Createarr(arr);

            Fill(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1} - massiv : ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Sumarr(arr);

            static int[][] Createarr(int[][] arr)
            {

                Random random = new Random();

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new int[random.Next(3, 7)];
                }
                return arr;
            }
            static int[][] Fill(int[][] arr)
            {
                Random random = new Random();

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = random.Next(3, 11);
                    }
                }
                return arr;
            }
            static int[][] Sumarr(int[][] arr)
            {
                int sum = 0, currenSum1 = 0, index = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        sum += arr[i][j];
                    }
                    if (sum > currenSum1)
                    {
                        currenSum1 = sum;
                        index = i;
                    }
                    sum = 0;
                }
                Console.WriteLine();
                Console.WriteLine($"{index + 1} - massiv eng katta yig'indiga ega , yigindi : " + currenSum1);
                return arr;
                
            }
            
        }
        
    }
}