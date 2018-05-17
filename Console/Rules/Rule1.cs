namespace GameOfLife.Rules
{
    public class Rule1 : IDefineARule
    {
        public bool IsMatched(bool alive, int liveNeighbours)
        {
            return alive && liveNeighbours < 2;
        }

        public RuleMatchedResult Check(bool alive, int liveNeighbours)
        {
            if (IsMatched(alive, liveNeighbours))
            {
                return new RuleMatchedResult {Rule = RuleEnum.One, NewState = false};
            }

            return null;
        }
    }
}