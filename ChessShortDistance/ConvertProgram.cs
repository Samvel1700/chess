
using ChessShortDistance.Models;

namespace ChessShortDistance
{
    public class ConvertPorgram
    {
        public static Position ConvertIndexes(string position)
        {
            char columnLetter = position[0];
            int rowNumber = int.Parse(position[1].ToString());

            int col = columnLetter - 'A';
            int row = 8 - rowNumber;

            Position CurrentPosition = new Position(row, col);
            return CurrentPosition;
        }


        public static void Run(out Position start, out Position end )
        {
            Console.Write("Write Start position(B1): ");
            string input1 = Console.ReadLine().ToUpper();
            start = ConvertIndexes(input1);
            Console.WriteLine("Start Position {0} , {1}", start.Row, start.Col);


            Console.Write("Write End position(C3): ");
            string input2 = Console.ReadLine().ToUpper();
            end = ConvertIndexes(input2);
            Console.WriteLine("End Position {0} , {1}", end.Row, end.Col);

        }
    }
}
