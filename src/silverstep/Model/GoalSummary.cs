using System;
using System.Collections.ObjectModel;

namespace SmallStep09.Model
{
    public class GoalSummary : DataObject
    {
        public GoalSummary()
        {
            RecentTrend = new TrendPointList();
        }

        /// <summary>
        /// Verbiage that states the goal.
        /// </summary>
        public string Statement { get; set; }

        /// <summary>
        /// List of recent trend points for this goal.
        /// </summary>
        public TrendPointList RecentTrend { get; set; }

        /// <summary>
        /// Total number of intervals that have passed
        /// since this goal was started.
        /// </summary>
        public int TotalIntervalsPassed { get; set; }

        /// <summary>
        /// Total number of intervals for which this
        /// goal was met.
        /// </summary>
        public int TotalSuccessfulIntervals { get; set; }
    }
}