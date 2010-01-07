using System;

namespace SmallStep09.Model
{
    public interface IGoalCriteria
    {
        ProgressInputType InputType { get; }
        bool GoalMet();
    }
}