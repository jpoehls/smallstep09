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
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow1 ch = new ChildWindow1();
            ch.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewUser ch = new NewUser();
            ch.Show();
        }
    }
}
