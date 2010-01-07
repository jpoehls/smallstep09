using System;

namespace SmallStep09.Model
{
    public class YesNoCriteria : IGoalCriteria
    {
        public YesNo PassingAnswer { get; set; }

        #region IGoalCriteria Members

        public ProgressInputType InputType
        {
            get { return ProgressInputType.YesNo; }
        }

        public virtual bool GoalMet()
        {
            return true;
        }

        #endregion
    }
}