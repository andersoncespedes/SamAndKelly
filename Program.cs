public static class Program
{
    public static int minNum()
    {
        Console.Write("Input the Amount of daily Exercises that SAM Resolves ->  ");
        int.TryParse(Console.ReadLine(), out int SamDaily);
        Console.Write("Input the Amount of daily Exercises that KELLY Resolves ->  ");
        int.TryParse(Console.ReadLine(), out int KellyDaily);
        Console.Write("Input the intitial Difference between KELLY and SAM -> ");
        int.TryParse(Console.ReadLine(), out int Diff);
        int SamD = SamDaily;
        int KellyD = KellyDaily;
        if (KellyDaily <= SamDaily)
        {
            return -1;
        }
        SamDaily += Diff;
        int i = 1;
        while (KellyDaily <= SamDaily)
        {
            KellyDaily += KellyD;
            SamDaily += SamD;
            i++;
        }
        return i;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(minNum());
    }
}