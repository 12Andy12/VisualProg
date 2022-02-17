public class program
{
    public class HW1
    {
        public static int QueueTime(int[] customers, int n)
        {
            int[] q = new int[n];
            int min;
            int minJ;
            for (int i = 0; i < customers.Length; ++i)
            {
                min = q[0];
                minJ = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (q[j] < min)
                    {
                        min = q[j];
                        minJ = j;
                    }
                }
                q[minJ] += customers[i];
            }

            int max = q[0];
            for (int i = 0; i < n; ++i)
            {
                if (q[i] > max)
                    max = q[i];
            }
            return max;
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter number of people: ");
        var n = Convert.ToInt32(Console.ReadLine());
        int[] customers = new int[n];

        for (var i = 0; i < n; ++i)
        {
            Console.Write($"time[{i}]= ");
            customers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter number of queue: ");
        var m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(HW1.QueueTime(customers,m));
    }
}
