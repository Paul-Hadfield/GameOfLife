namespace GameOfLife.Rules
{
    public interface IDefineARule
    {
        bool IsMatched(bool alive, int liveNeighbours);

        RuleMatchedResult Check(bool alive, int liveNeighbours);
    }
}
