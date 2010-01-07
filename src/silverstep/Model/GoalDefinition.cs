using System;

namespace SmallStep09.Model
{
    public class GoalDefinition : GoalSummary
    {
        public IGoalCriteria Criteria { get; set; }
    }
}