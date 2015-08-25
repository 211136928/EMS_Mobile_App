using EMS_Mobile_App.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace EMS_Mobile_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResetPasswordPage : Page
    {
        public ResetPasswordPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


        

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgettenPassword));
        }
        private async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            string id, password, rePassword;
            string msg = "";
            validation objValidate = new validation();
            Method obj = new Method();


            id = txtID.Text;
            password = txtPassword.Password;
            rePassword = txtReEnterPassword.Password;
            try
            {
                if (objValidate.validatePassword(password,rePassword) != "")
                {
                    msg = "MAke sure your password match re- enter again";
                    messageBox(msg);
                }else
                {
                    msg = "Your password have been reset";
                    messageBox(msg);
                    this.Frame.Navigate(typeof(MainPage));
                }

            }
            catch(Exception ex)
            {
                messageBox(msg + ex.Message);
            }

            



        }
    }
}
