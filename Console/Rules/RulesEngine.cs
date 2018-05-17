﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Rules
{
    public class RulesEngine : IDefineARulesEngine
    {
        private readonly IList<IDefineARule> rules;

        public RulesEngine()
        {
            this.rules = new List<IDefineARule>()
            {
                new Rule1(),
                new Rule2(),
                new Rule3(),
                new Rule4()
            };
        }

        public bool DetermineNewState(bool currentState, int numberOfLiveNeighbours)
        {
            var results = this.rules.Select(rule => rule.Check(currentState, numberOfLiveNeighbours)).ToList();

            results = results.Where(r => r != null).ToList();
            switch (results.Count)
            {
                case 0:
                    return false;
                case 1:
                    return results[0].NewState;
            }

            throw new ApplicationException("More than one rule matched");
        }
    }
}