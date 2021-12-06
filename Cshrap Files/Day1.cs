namespace Advent_of_Coding
{
    public class Day1
    {
        public void ArrayIncreases(string[] fileLines)
        {
            int increases = 0;
            int current, previous;
            //string[] fileLines = System.IO.File.ReadAllLines(@"Day 1 - Sub Depth\input.txt");
            previous = Int32.Parse(fileLines[0]);
            foreach (string line in fileLines)
            {
                current = Int32.Parse(line);
                if (current > previous)
                {
                    increases++;
                }
                previous = current;
            }
            Console.Write("Day 1 " + increases + "\n");
            //partII
            int increases2 = 0;
            for (int i = 3; i < fileLines.Length; i++)
            {
                int sum1 = Int32.Parse(fileLines[i - 3]) + Int32.Parse(fileLines[i - 2]) + Int32.Parse(fileLines[i - 1]);
                int sum2 = Int32.Parse(fileLines[i - 1]) + Int32.Parse(fileLines[i - 2]) + Int32.Parse(fileLines[i - 0]);
                if (sum1 < sum2)
                {
                    increases2++;
                }
            }
            Console.WriteLine(increases2 + "\n");
        }
    }
}