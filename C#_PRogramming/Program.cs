class Program
{
    static void Main(string[] args)
    {
        #region Reverse String
        //Console.WriteLine("Enter the Sentence to reverse :");
        //string name = Console.ReadLine();
        //string rev = "";

        //for (int i = name.Length - 1; i>=0; i--)
        //{
        //    rev = rev + name[i];
        //}
        //Console.WriteLine($"Reverse String {rev}");
        #endregion

        #region Palindrome
        //Console.WriteLine("Enter values to check Palindrome :");
        //string val = Console.ReadLine().ToLower();
        //string rev = "";
        //for(int i = val.Length -1; i >=0; i--)
        //{
        //    rev = rev + val[i];
        //}
        //if(val == rev)
        //{
        //    Console.WriteLine("Palindrome.");
        //}
        //else
        //{
        //    Console.WriteLine("NO Palindrome");
        //}

        //Console.ReadLine();


        #endregion

        #region Factorial Number
        int n = 5;
        int i = 1;

        for(int j = 1; j <= n; j++)
        {
            i = i * j;
        }
        Console.WriteLine(i);

        #endregion





        Console.ReadKey();
    }
}