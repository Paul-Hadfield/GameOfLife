namespace GameOfLife.Rules
{
    public class Rule3 : IDefineARule
    {
        public bool IsMatched(bool alive, int liveNeighbours)
        {
            if (alive && liveNeighbours > 3)
            {
                return true;
            }

            return false;
        }

        public RuleMatchedResult Check(bool alive, int liveNeighbours)
        {
            if (IsMatched(alive, liveNeighbours))
            {
                return new RuleMatchedResult { Rule = RuleEnum.Three, NewState = false };
            }

            return null;
        }

    }
}