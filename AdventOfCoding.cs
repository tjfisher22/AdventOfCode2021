namespace Advent_of_Coding
{
    class AdventOfCoding
    {
        static void Main()
        {
            Day1 _day1 = new Day1();
            Day2 _day2 = new Day2();
            Day3 _day3 = new Day3();

            //string[] _day1Input = System.IO.File.ReadAllLines(@"Inputs\Day1.txt");
            //string[] _day2Input = System.IO.File.ReadAllLines(@"Inputs\Day2.txt");
            string[] _day3Input = System.IO.File.ReadAllLines(@"Inputs\Day3.txt");

            //_day1.ArrayIncreases(_day1Input);
            //_day2.Movement(_day2Input);
            _day3.Diagnostics(_day3Input);

        }
    }
}