using System;

namespace SmallStep09.Model
{
    public class NumericCriteria : IGoalCriteria
    {
        public int MinimumPassingValue { get; set; }
        public int MaximumPassingValue { get; set; }

        #region IGoalCriteria Members

        public ProgressInputType InputType
        {
            get { return ProgressInputType.Numeric; }
        }

        public virtual bool GoalMet()
        {
            return true;
        }

        #endregion
    }
}