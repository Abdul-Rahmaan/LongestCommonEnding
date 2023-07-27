class Program
{
    static void Main(string[] args)
    {
        //string str1 = "running ,";
        //string str2 = "ruminating";

        //Console.WriteLine("Original strings: " + str1 + "  " + str2);

        //Console.WriteLine("\nCommon ending between the two strings: " + test(str1, str2) + "\n");

        //string str3 = "multiplication ,";
        //string str4 = "addition";

        //Console.WriteLine("Original strings: " + str3 + "  " + str4);
        //Console.WriteLine("\nCommon ending between the strings are: " + test(str3, str4));

        string str1 , str2;

        Console.Write("enter the first string :");
        str1 = Console.ReadLine();
        Console.Write("enter the second string :");
        str2 = Console.ReadLine();

        Console.WriteLine("\nOriginal strings: " + str1 + "  " + str2 + "\n");

        test(str1,str2);
        Console.Write("the common end points are: ");
        Console.WriteLine(test(str1,str2));
   
    }
    public static string test(string st1, string st2)
    {
        for (int i = 0; i < st1.Length; i++)
        {
            string end = st1.Substring(i);
            if (st2.EndsWith(end))
            {
                return end;
            }
            //else
            //{
            //    Console.WriteLine("there is no common points in last");
            //}
        }
        return "";
    }
}