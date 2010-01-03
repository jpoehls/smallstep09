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
using SmallStep09.Services;

namespace SmallStep09
{
    public partial class ChildWindow1 : ChildWindow
    {
        public ChildWindow1()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            var svc = new GoalService();
            svc.ValidateUserAsync(uxUsername.Text.Trim(), uxPassword.Text, UserValidated);
        }

        private void UserValidated(bool isValidUser)
        {
            MessageBox.Show("User is valid? " + isValidUser);
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

