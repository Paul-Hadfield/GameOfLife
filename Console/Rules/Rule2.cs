namespace GameOfLife.Rules
{
    public class Rule2 : IDefineARule
    {
        public bool IsMatched(bool alive, int liveNeighbours)
        {
            if (alive  && (liveNeighbours == 2 || liveNeighbours == 3))
            {
                return true;
            }

            return false;
        }
    }
}