namespace GameOfLife.Rules
{
    public interface IDefineARule
    {
        bool IsMatched(bool alive, int liveNeighbours);
    }
}
