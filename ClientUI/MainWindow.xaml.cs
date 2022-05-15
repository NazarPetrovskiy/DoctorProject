using ClientUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowLogin login = new WindowLogin();
            if(login.ShowDialog() == true)
            {
                InitializeComponent();
            }
            else
            {
                this.Close();
            }

            textboxSpeciality.Text = "Doctor";
            textboxName.Text = "Mark";
            textboxLastname.Text = "Klarson";
            textboxAge.Text = "15";
        }

        private void SetTextBox_IsReadOnly(bool status)
        {
            textboxSpeciality.IsReadOnly = status;
            textboxName.IsReadOnly = status;
            textboxLastname.IsReadOnly = status;
            textboxAge.IsReadOnly = status;
        }

        private void SetUpTextBoxTags()
        {
            textboxSpeciality.Tag = textboxSpeciality.Text;
            textboxName.Tag = textboxName.Text;
            textboxLastname.Tag = textboxLastname.Text;
            textboxAge.Tag = textboxAge.Text;
        }

        private void SetTagsToTextBox()
        {
            textboxSpeciality.Text = textboxSpeciality.Tag.ToString();
            textboxName.Text = textboxName.Tag.ToString();
            textboxLastname.Text = textboxLastname.Tag.ToString();
            textboxAge.Text = textboxAge.Tag.ToString();
        }

        private void ButtonEditVisibility(bool status)
        {
            if (status)
            {
                buttonEditApply.Visibility = Visibility.Visible;
                buttonEditCancel.Visibility = Visibility.Visible;
                buttonEditInfo.IsEnabled = false;
            }
            else
            {
                buttonEditApply.Visibility = Visibility.Hidden;
                buttonEditCancel.Visibility = Visibility.Hidden;
                buttonEditInfo.IsEnabled = true;
            }
        }

        private void buttonEditInfo_Click(object sender, RoutedEventArgs e)
        {

            SetUpTextBoxTags();

            textboxSpeciality.Clear();
            textboxName.Clear();
            textboxLastname.Clear();
            textboxAge.Clear();

            textboxSpeciality.Focus();

            SetTextBox_IsReadOnly(false);

            ButtonEditVisibility(true);
        }

        private void buttonEditApply_Click(object sender, RoutedEventArgs e)
        {
            buttonEditApply.Visibility = Visibility.Hidden;
            buttonEditCancel.Visibility = Visibility.Hidden;
            buttonEditInfo.IsEnabled = true;

            SetTextBox_IsReadOnly(true);
        }

        private void buttonEditCancel_Click(object sender, RoutedEventArgs e)
        {
            SetTagsToTextBox();
            ButtonEditVisibility(false);
        }

        private void buttonHide_Click(object sender, RoutedEventArgs e)
        {
            if (buttonHide.Content.ToString() == "Hide")
                buttonHide.Content = "Show";
            else
                buttonHide.Content = "Hide";

            
        }
    }
}