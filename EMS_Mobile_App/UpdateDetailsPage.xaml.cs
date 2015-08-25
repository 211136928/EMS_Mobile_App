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
    public sealed partial class UpdateDetailsPage : Page
    {
        public string idNum;
        public UpdateDetailsPage()
        {
            this.InitializeComponent();
           
            btnUpdate.IsEnabled = false;
            txtEmail.IsEnabled = false;
            txtSurname.IsEnabled = false;
            txtCellNumber.IsEnabled = false;
            txtHomeAddress.IsEnabled = false;
            idNum = txtID.Text;

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            string surname, email, cellNumber, homeAddress, province;

            surname = txtSurname.Text;
            email = txtEmail.Text;
            cellNumber = txtCellNumber.Text;
            homeAddress = txtHomeAddress.Text;
            province = "";

            Method obj = new Method();

            obj.updateDetails(surname, cellNumber, email, homeAddress, "9102015333086");





        }
        public async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

        private void btnVerifyUser_Click(object sender, RoutedEventArgs e)
        {

            string id = txtID.Text;
            Method obj = new Method();
            string msg = "";


            var user = obj.getRegisterUser(id);

            if(user == null)
            {

                msg = "please check your id number ";
                messageBox(msg);
            }
            else
            {
                txtID.IsEnabled = false;
                btnUpdate.IsEnabled = true;
                txtEmail.IsEnabled = true;
                txtSurname.IsEnabled = true;
                txtCellNumber.IsEnabled = true;
                txtHomeAddress.IsEnabled = true;

                lblDisplayName.Text = user.Name;
                txtSurname.Text = user.Surname;
                txtEmail.Text = user.Email;
                txtCellNumber.Text = user.CellNum;
            }


        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }
    }
}
