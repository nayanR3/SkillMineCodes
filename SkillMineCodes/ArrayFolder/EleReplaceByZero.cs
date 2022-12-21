/*Q9. Replace element by 0 if it's divisible by 3*/
class EleReplaceByZero
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("size of array");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("\nenter array element");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(" ", t.Fun(a)));
    }

    public int[] Fun(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 3 == 0)
            {
                a[i] = 0;
            }
        }
        return a;
    }
}
