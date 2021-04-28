using System;
public class Program
{
	
public static void findallsubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str.Length-i);
                for (int j = 0; j < str.Length; j++)
                {
                    stringBuilder.Append(str[j]);
                    Console.Write(stringBuilder+ " ");
                }
            }
        }
        public static void Main()
        {
            program.findallsubstrings("abcd");
            Console.ReadLine();
        }
	}
}