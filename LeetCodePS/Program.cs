namespace LeetCodePS;

public static class Program
{
    public static void Main()
    {
        var result = RomanToInt("XXVII");
        
        Console.WriteLine(result);
    }

    private static int RomanToInt(string s)
    {
        var romanEquiv = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };


        var intNumber = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var ch = s.ElementAt(i);
            var a = romanEquiv.GetValueOrDefault(ch);

            if (i + 1 < s.Length)
            {
                int b = romanEquiv[s.ElementAt(i + 1)];

                if (a >= b)
                {
                    intNumber += a;
                }
                else
                {
                    intNumber -= a;
                }
            }
            else
            {
                intNumber += a;
            }
        }

        return intNumber;
    }
}