//Console.WriteLine("Hello, World!");

using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please write you Roman number to be converted into usual way: ");
        string Roman = Console.ReadLine();
        int meter = Roman.Length;
        int number = 0;
        string[] chars = new string[meter];
        for(int i = 0; i < Roman.Length - 1; i++)
        {
            chars[i] = Convert.ToString(Roman[i]);
        }
        for (int i = 0; i < chars.Length; i++)
        {
            int j = i + 1;
            int temp = Converter(chars[i]);
            int check = Checker(chars[j], temp);
            if (temp != check )
            {
                i++;
            }
            number += check;
        }

        Console.WriteLine($"number: {number}");
        int Converter (string Rom)
        {
            int result = 0;
            switch (Rom)
            {
                case "M":
                    result = 1000;
                    break;
                case "D":
                    result = 500;
                    break;
                case "C":
                    result = 100;
                    break;
                case "L":
                    result = 50;
                    break;
                case "X":
                    result = 10;
                    break;
                case "V":
                    result = 5;
                    break;
                case "I":
                    result = 1;
                    break;
            }
            return result;
        }
        int Checker (string num, int tmp)
        {
            int numbNextTo = 0;
            switch (num)
            {
                case "M":
                    numbNextTo = 1000;
                    break;
                case "D":
                    numbNextTo = 500;
                    break;
                case "C":
                    numbNextTo = 100;
                    break;
                case "L":
                    numbNextTo = 50;
                    break;
                case "X":
                    numbNextTo = 10;
                    break;
                case "V":
                    numbNextTo = 5;
                    break;
                case "I":
                    numbNextTo = 1;
                    break;
            }
            if (numbNextTo > tmp)
            {
                return numbNextTo - tmp;
            }
            return tmp;
        }
    }
}