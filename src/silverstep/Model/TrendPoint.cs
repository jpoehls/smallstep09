using System;
using System.ComponentModel;

namespace SmallStep09.Model
{
    /// <summary>
    /// Represents a single point in
    /// the trending stats of a goal.
    /// </summary>
    public class TrendPoint : Observable<TrendPoint>
    {
        private static readonly PropertyChangedEventArgs _goalMetChangeArgs = CreateChangeArgs(x => x.GoalMet);
        private static readonly PropertyChangedEventArgs _goalTotalChangeArgs = CreateChangeArgs(x => x.GoalTotal);
        private static readonly PropertyChangedEventArgs _intervalDateChangeArgs = CreateChangeArgs(x => x.IntervalDate);

        private static readonly PropertyChangedEventArgs _intervalTotalChangeArgs =
            CreateChangeArgs(x => x.IntervalTotal);

        private bool _goalMet;
        private int _goalTotal;
        private string _intervalDate;
        private int _intervalTotal;


        /// <summary>
        /// True/False whether or not
        /// the goal was met this interval.
        /// </summary>
        public bool GoalMet
        {
            get { return _goalMet; }
            set
            {
                if (_goalMet == value)
                    return;

                _goalMet = value;
                NotifyChange(_goalMetChangeArgs);
            }
        }

        /// <summary>
        /// Total recorded progress for this interval.
        /// For Yes/No goals this will simply be a 1 (yes) or 0 (no).
        /// For numeric goals this will be the total entered for the
        /// entire interval.
        /// </summary>
        public int IntervalTotal
        {
            get { return _intervalTotal; }
            set
            {
                if (_intervalTotal == value)
                    return;

                _intervalTotal = value;
                NotifyChange(_intervalTotalChangeArgs);
            }
        }

        /// <summary>
        /// Total progress required to meet the goal.
        /// </summary>
        public int GoalTotal
        {
            get { return _goalTotal; }
            set
            {
                if (_goalTotal == value)
                    return;

                _goalTotal = value;
                NotifyChange(_goalTotalChangeArgs);
            }
        }

        /// <summary>
        /// Date to plot this trend point at.
        /// This should match the ending date
        /// for this interval.
        /// </summary>
        public string IntervalDate
        {
            get { return _intervalDate; }
            set
            {
                if (_intervalDate == value)
                    return;

                _intervalDate = value;
                NotifyChange(_intervalDateChangeArgs);
            }
        }
    }
}