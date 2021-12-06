using System;
namespace Advent_of_Coding
{
    public class Day3
    {
        internal void Diagnostics(string[] input)
        {
            int[] bitCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double finalBits = 0b000000000000;
            int bitLength = input[0].Length;
            for (int i = 0; i < input.Length; i++)
            {
                char[] line = input[i].ToCharArray();
                for (int j = 0; j < bitLength; j++)
                {
                    bitCount[j] += line[j] == '0' ? 0 : 1;
                }

            }
            //Console.WriteLine("Final BitCount");
            for (int j = 0; j < bitLength; j++)
            {
                finalBits += bitCount[j] > input.Length / 2 ? Math.Pow(2, (bitLength - 1 - j)) : 0;
                // Console.WriteLine(bitCount[j]);
            }
            int gamma = Convert.ToInt32(finalBits);
            int epsilon = Convert.ToInt32(Math.Pow(2, bitLength) - 1 - finalBits); //flips the bits
            string gammaBits = Convert.ToString(gamma, 2);
            string epsilonBits = Convert.ToString(epsilon, 2);
            Console.WriteLine($"Gamma Rate is {gammaBits} or {gamma}  in decimal");
            Console.WriteLine($"Epsilon Rate is {epsilonBits} or {epsilon}  in decimal");
            Console.WriteLine($"Part I Answer is {gamma * epsilon}");

        }
    }
}