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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace EMS_Mobile_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

    
        public MainPage()
        {
            this.InitializeComponent();
            
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(registerPage));
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {

            
           // this.Frame.Navigate(typeof(HomePage));
            string email, password;

            Method objM = new Method();

            email = txtEmail.Text;
            password = txtPassword.Password;

            var valid = objM.getLogIN(email, password);
            if(email.Trim() == "" && password.Trim() == "")
            {
                messageBox("please enter yuor email and password");
            }else
                {
                if (valid != null)
                    {
                        this.Frame.Navigate(typeof(HomePage));
                    }
                else
                {
                    messageBox("you passsword and email dont match please rectify");
                }
            }

        }

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ResetPasswordPage));

        }

        private async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

        private void btnRequestHelp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
