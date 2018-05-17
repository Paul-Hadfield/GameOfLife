using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Rules
{
    public class RulesEngine : IDefineARulesEngine
    {
        public bool DetermineNewState(bool currentState, int numberOfLiveNeighbours)
        {
            var results = new List<RuleMatchedResult>
            {
                new Rule1().Check(currentState, numberOfLiveNeighbours),
                new Rule2().Check(currentState, numberOfLiveNeighbours),
                new Rule3().Check(currentState, numberOfLiveNeighbours),
                new Rule4().Check(currentState, numberOfLiveNeighbours)
            };
            
            results = results.Where(r => r != null).ToList();
            if (results.Count == 0)
            {
                return false;
            }

            if (results.Count == 1)
            {
                return results[0].NewState;
            }

            throw new ApplicationException("More than one rule matched");
        }
    }
}