using ChessShortDistance.Models;

namespace ChessShortDistance.PiecesOneMoveSteps
{
    public class BishopCanMoveInOneStep
    {
        public static bool Run(Position start, Position end)
        {
            int dx = Math.Abs(start.Row - end.Row);
            int dy = Math.Abs(start.Col - end.Col);

            return dx == dy && dx != 0;
        }

    }
}
