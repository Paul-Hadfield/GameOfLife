namespace GameOfLife.Rules
{
    public class Rule4 : IDefineARule
    {
        public bool IsMatched(bool alive, int liveNeighbours)
        {
            if (!alive && (liveNeighbours == 3))
            {
                    return true;
            }

            return false;
        }
    }
}