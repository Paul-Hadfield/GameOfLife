namespace GameOfLife.Rules
{
    public class Rule1 : IDefineARule
    {
        public bool IsMatched(bool alive, int liveNeighbours)
        {
            return alive && liveNeighbours < 2;
        }
    }
}