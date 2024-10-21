namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 14; i++)
            {
                list.Add(rnd.Next(-10, 20));
            }
            Console.WriteLine($"Original list -> {string.Join(" ", list)}");
            Replace(list);
            PosSum(list);
            MinMaxDiff(list);
        }
        static void Replace (List<int> list)
        {
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list[i] = 0;
                }
            }
            Console.WriteLine($"Replaced list -> {string.Join(" ", list)}");
        }
        static void PosSum (List<int> list)
        {
            int sum = 0;
            for (int i = 0;i < list.Count ; i++)
            {
                if (list[i] > 0)
                {
                    sum += list[i];
                }
            }
            Console.WriteLine($"The sum of the positive numbers is {sum}");
        }
        static void MinMaxDiff(List<int> list)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min )
                {
                    min = list[i];
                }
                else if (list[i] > max)
                {
                    max = list[i];
                }
            }
            Console.WriteLine($" min value   {min}\n max value  {max}\n difference  {max-min}");
        }
    }
}
