namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Reverse(120));
            Console.ReadKey();
        }
    }

    public static class Solution
    {
        public static int Reverse(int x)
        {
            var s = x.ToString().Select(item => item).ToList();

            var tempString = string.Empty;

            var isNegative = false;

            for (int i = s.Count - 1; i >=0 ; i--)
            {
                if (s[i] == '-')
                {
                    isNegative = true;
                }
                else
                {
                    tempString = $"{tempString}{s[i]}";
                }
                
            }
            
            if(isNegative)
            {
                tempString = $"-{tempString}";
            }


            if(Int32.TryParse(tempString, out int result))
            {
                return result;
            }

            return 0;
        }
    }
}