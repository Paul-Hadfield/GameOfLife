namespace GameOfLife.Rules
{
    public class RulesEngine : IDefineARulesEngine
    {
        public bool DetermineNewState(bool currentState, int numberOfLiveNeighbours)
        {
            if (new Rule1().IsMatched(currentState, numberOfLiveNeighbours))
            {
                return false;
            }

            if (new Rule2().IsMatched(currentState, numberOfLiveNeighbours))
            {
                return true;
            }

            if (new Rule3().IsMatched(currentState, numberOfLiveNeighbours))
            {
                return false;
            }

            if (new Rule4().IsMatched(currentState, numberOfLiveNeighbours))
            {
                return true;
            }

            return false;
        }
    }
}