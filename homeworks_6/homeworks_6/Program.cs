namespace homeworks_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            console.writeline("hello, world!");
            console.write("enter a number : ");
            int n = convert.toint32(console.readline());
            int[] summ = new int[n];
            int sanoq = 2, sanoq2 = 0, sum = 0;
            while (true)
            {
                if (sanoq % 2 != 0)
                {
                    summ[sanoq2] = sanoq;
                    sum++;
                    sanoq2++;
                }
                if (sum == n)
                {
                    break;
                }
                sanoq++;
            }
            for (int i = 0; i < n; i++)
            {
                console.write($" {summ[i]} , ");
            }
        }
    }
}
