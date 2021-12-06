namespace Advent_of_Coding
{
    public class Day2
    {
        public void Movement(string[] input)
        {
            string[] line;
            int[] pos = { 0, 0 };
            for (int i = 0; i < input.Length; i++)
            {
                line = input[i].Split(' ');
                switch (line[0])
                {
                    //horizontal movement
                    case "forward":
                        pos[0] += Int32.Parse(line[1]);
                        break;
                    case "back": //not used?
                        pos[0] -= Int32.Parse(line[1]);
                        break;
                    //depth (Postitive is down)
                    case "down":
                        pos[1] += Int32.Parse(line[1]);
                        break;
                    case "up":
                        pos[1] -= Int32.Parse(line[1]);
                        break;
                }
            }
            Console.WriteLine($"Moved {pos[0]} units forward and {pos[1]} down.");
            Console.WriteLine($"Day2 part1 answer is {pos[0] * pos[1]}");
            //partII adds aim
            int[] pos2 = { 0, 0 };
            int aim = 0;
            for (int i = 0; i < input.Length; i++)
            {
                line = input[i].Split(' ');
                switch (line[0])
                {
                    //horizontal movement
                    case "forward":
                        pos2[0] += Int32.Parse(line[1]);
                        pos2[1] += Int32.Parse(line[1]) * aim;
                        break;
                    case "back": //not used?
                        pos2[0] -= Int32.Parse(line[1]);
                        pos2[1] -= Int32.Parse(line[1]) * aim;
                        break;
                    //depth (Postitive is down)
                    case "down":
                        aim += Int32.Parse(line[1]);
                        break;
                    case "up":
                        aim -= Int32.Parse(line[1]);
                        break;
                }
            }
            Console.WriteLine("PartII");
            Console.WriteLine($"Moved {pos2[0]} units forward and {pos2[1]} down.");
            Console.WriteLine($"Day2 part2 answer is {pos2[0] * pos2[1]}");
        }

    }
}