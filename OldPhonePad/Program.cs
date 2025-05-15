using System;

namespace OldPhonePad
{
    /// <summary>
    /// Entry point for the console application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old Phone Pad Simulator");
            Console.WriteLine("Enter your keypad input (end with #):");

            string input = Console.ReadLine();
            string result = OldPhone.OldPhonePadInput(input);

            Console.WriteLine($"Decoded Output: {result}");
        }
    }
}
