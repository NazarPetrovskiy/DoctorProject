using ClientUI.ViewModels;
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
using System.Windows.Shapes;

namespace ClientUI.Windows
{
    public partial class WindowLogin : Window
    {
        public WindowLogin(BaseViewModel baseViewModel)
        {
            InitializeComponent();
            this.DataContext = baseViewModel;
            ChangeMainGrid(0, 1, 1, 1, 200, 500);
        }

        #region UI methods
        private void ChangeMainGrid(int gridLog, int gridSig, int porgotGrid, int confGrid, int heith, int with)
        {
            Grid.SetRow(GridLogin, gridLog);
            Grid.SetRow(GridSigIn, gridSig);
            Grid.SetRow(GridForgout, porgotGrid);
            Grid.SetRow(GridConfirm, confGrid);
            this.Height = heith;
            this.Width = with;
        }
        #endregion

        #region Events
        //
        #region LogIn events
        private void LoginClick(object sender, RoutedEventArgs e) //
        {
            //this.DialogResult = true;
            this.Close();
        }
        private void SigInMouseDown(object sender, MouseButtonEventArgs e) { ChangeMainGrid(1, 0, 1, 1, 350, 500); }
        private void ForgotPasswordMouseDown(object sender, MouseButtonEventArgs e) { ChangeMainGrid(1, 1, 0, 1, 200, 500); }
        #endregion
        //
        #region SigIn events
        private void SigInClick(object sender, RoutedEventArgs e) //
        {
            this.DialogResult = true;
            this.Close();
        }
        #endregion
        //
        #region Forgot password events
        private void CheckClick(object sender, RoutedEventArgs e) //
        {
            ChangeMainGrid(1, 1, 1, 0, 200, 500);
        }
        #endregion
        //
        #region Continue events
        private void ConfirmClick(object sender, RoutedEventArgs e) //
        {
            this.DialogResult = true;
            this.Close();
        }
        #endregion

        #region Label events
        private void LabelMouseEnter(object sender, MouseEventArgs e) { ((Label)sender).Foreground = Brushes.Red; }
        private void LabelMouseLeave(object sender, MouseEventArgs e) { ((Label)sender).Foreground = Brushes.Blue; }
        private void LabelLogInMouseDown(object sender, MouseButtonEventArgs e) { ChangeMainGrid(0, 1, 1, 1, 200, 500); }
        #endregion
        #endregion
    }
}
