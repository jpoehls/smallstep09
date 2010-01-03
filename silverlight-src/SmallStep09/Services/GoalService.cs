using System;
using System.Net;
using System.Net.Browser;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using SmallStep09.Model;

namespace SmallStep09.Services
{
    public class GoalService
    {
        public IEnumerable<Goal> GetActiveGoals()
        {
            var list = new List<Goal>
            {
                new Goal{ 
                    Id=1,
                    InputType=ProgressInputType.Numeric,
                    Prompt="Do at least 25 push-ups a day",
                    PassingCriteria=new NumericGoalCriteria{
                        MinimumPassingValue=25,
                        MaximumPassingValue=int.MaxValue
                    }
                },
                new Goal{ 
                    Id=2,
                    InputType=ProgressInputType.YesNo,
                    Prompt="Pray every day",
                    PassingCriteria=new YesNoGoalCriteria{
                        PassingAnswer=YesNo.Yes
                    }
                }
            };

            return list;
        }

        public void ValidateUserAsync(string username, string password, Action<bool> callback)
        {
            var url = new Uri("http://localhost:8080/svc/profiles/" + username);

            var wc = new WebClient();
            wc.DownloadStringCompleted += ValidateUserCompleted;
            wc.DownloadStringAsync(url, callback);
        }

        private void ValidateUserCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var callback = (Action<bool>) e.UserState;
            if (e.Result.Contains("joshua"))
            {
                callback(true);
            }
            else
            {
                callback(false);
            }
        }
    }
}
