using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SmallStep09.Model
{
    public class Goal
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public ProgressInputType InputType { get; set; }

        public GoalCriteria PassingCriteria { get; set; }
    }

    public class GoalProgress
    {

    }

    public abstract class GoalCriteria
    {
        public abstract bool GoalMet();
    }

    public class NumericGoalCriteria : GoalCriteria
    {
        public int MinimumPassingValue { get; set; }
        public int MaximumPassingValue { get; set; }

        public override bool GoalMet()
        {
            return true;
        }
    }

    public class YesNoGoalCriteria : GoalCriteria
    {
        public YesNo PassingAnswer { get; set; }

        public override bool GoalMet()
        {
            return true;
        }
    }
}

