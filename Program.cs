using System;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranid");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "into");
            hash.Add("15", "paranoid");
            hash.Add("16", "avoidale");
            hash.Add("17", "situation");

            string hash0 = hash.Get("0");
            Console.WriteLine(" 0th index value : " + hash0);
        }
    }
}