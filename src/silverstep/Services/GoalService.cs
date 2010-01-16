using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using SmallStep09.Model;

namespace SmallStep09.Services
{
    public class GoalService
    {
        public IList<GoalSummary> GetActiveGoals()
        {
            return null;
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
            
            var callback = (Action<bool>)e.UserState;
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