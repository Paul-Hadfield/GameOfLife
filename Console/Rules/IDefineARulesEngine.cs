namespace GameOfLife.Rules
{
    public interface IDefineARulesEngine
    {
        bool DetermineNewState(bool currentState, int numberOfLiveNeighbours);
    }
}
