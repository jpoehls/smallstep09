using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SmallStep09
{
    public partial class GoalButton : UserControl
    {
        public GoalButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chart.DataContext = new KeyValuePair<DateTime, int>[] {
    new KeyValuePair<DateTime, int>(DateTime.Today.AddHours(8), 9), 
    new KeyValuePair<DateTime, int>(DateTime.Today.AddHours(12), 2), 
    new KeyValuePair<DateTime, int>(DateTime.Today.AddHours(16), 4), 
    new KeyValuePair<DateTime, int>(DateTime.Today.AddHours(20), 8), 
    new KeyValuePair<DateTime, int>(DateTime.Today.AddHours(21), 1) };
        }
    }
}
