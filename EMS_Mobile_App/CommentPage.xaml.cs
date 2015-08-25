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
    public sealed partial class CommentPage : Page
    {
        public CommentPage()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void btnComment_Click(object sender, RoutedEventArgs e)
        {
           Method objCom = new Method();
           validation objValidate = new validation();
           string msg = "";

            string name,surname, email,comment, id,comOrcompl, date;
            int complainID = 0;


            email = txtEmail.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            comment = txtComments.Text;
            comOrcompl = "complains";
            date = DateTime.Now.ToString();

            //this valid variable will have access to get the id number of a user

            var valid = objCom.getRegUser(name);
            
          

            // validadate all variable and set the comment in table comment
            try
            {
               
                
                    msg = objValidate.validateString(name);
                    msg +=  objValidate.validateString(surname);
                    msg +=  objValidate.validateEmail(email);
               if (msg == "") 
               {
                     id = valid.ID;
                   if(id== null)
                    {
                         messageBox("Please name sure that you enter your correct name");
                    }else
                        { 
                            objCom.setComplains(complainID, id, name, surname, email, comment, comOrcompl);
                            messageBox("Thanks you for commenting, your input will make us improve our service" + id);
                            //this.Frame.Navigate(typeof(MainPage));
                        }
                }

               else
               {
                   messageBox(msg);
               }
                             
               
                    
                
            }
            catch(Exception ex)
            {
                messageBox(ex.Message);
            }
   }        
  private async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

  private void btnViewPreviousComm_Click(object sender, RoutedEventArgs e)
  {
      this.Frame.Navigate(typeof(viewPreviousCommentPage));
  }





       
    }
}
