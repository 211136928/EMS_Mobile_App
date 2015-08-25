using EMS_Mobile_App;
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
using EMS_Mobile_App.table;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace EMS_Mobile_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class registerPage : Page
    {
        private validation obj;
        public registerPage()
        {
            this.InitializeComponent();

           lstProvince.Items.Add("Gauteng");
           lstProvince.Items.Add("Limpopo");
           lstProvince.Items.Add("Western Cape");
           lstProvince.Items.Add("Free State");
           lstProvince.Items.Add("Mpumapanga");
           lstProvince.Items.Add("Nort West");
           lstProvince.Items.Add("Kwazulu Natal");
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {   
         
            obj = new validation();
            String IDnum,cell, name, surname, homeAddress, email, password, repassword, gender;
            int age;
            IDnum = txtID.Text;
            name = txtName.Text;
            homeAddress = txtHomeAddress.Text;
            email = txtEmail.Text;
            password = txtPassword.Password;
            repassword = txtRe_password.Password;
            surname = txtSurname.Text;
           cell = txtCellnumber.Text;


            var objReg = new Method();

            try
            {

              gender = obj.getGender(IDnum);
              age = obj.getAge(IDnum);

              objReg.setRegister(IDnum, name, surname, email, cell, gender, age, password);
              
              messageBox("Thanks you for registering for Emergency Medical Servise");
            
                 this.Frame.Navigate(typeof(MainPage));
            }
            catch (Exception ex)
            {
                messageBox(ex.Message);
            }
            
            
           
        }
        private async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

           this.Frame.Navigate(typeof(MainPage));
        }


        public string getName()
        {
            string name;


            name = "wisani";

            return name;
        }
    }
}
