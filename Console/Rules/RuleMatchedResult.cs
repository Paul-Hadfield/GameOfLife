namespace GameOfLife.Rules
{
    public class RuleMatchedResult
    {
        public RuleEnum Rule { get; set; }

        public bool NewState { get; set; }
    }

    public enum RuleEnum
    {
        One,
        Two,
        Three,
        Four
    }
}
