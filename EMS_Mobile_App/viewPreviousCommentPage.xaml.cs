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
    public sealed partial class viewPreviousCommentPage : Page
    {
        public viewPreviousCommentPage()
        {
            this.InitializeComponent();
            lstViewPreComm.Items.Add("Type of comment                  Comment                         Date");
            lstViewPreComm.Items.Add("");
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // Method obj = new Method();

            /*  getComment();
            string msg = "";
            lstViewPreComm.Items.Add("Type of comment                  Comment                         Date");
            lstViewPreComm.Items.Add("");


            Method obj = new Method();
             int comID = 0;
             var objCom = obj.getComment(comID);

          
           if (objCom == null)
             {
                 msg = "No record was found in the data base, you didnt make any comment about our servince ";
                 messageBox(msg);
             }
             else
             {
                 while (objCom != null)
                 {
                     lstViewPreComm.Items.Add(objCom.Name + "  " + objCom.Comment);
                     comID = comID + 1;
                     objCom = obj.getComment(comID);
                 }
             }
             */

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CommentPage));
        }
        private async void messageBox(string msg)
        {
            var msgDisplay = new Windows.UI.Popups.MessageDialog(msg);
            await msgDisplay.ShowAsync();
        }

        public void getComment()
        {
            string msg = "";
            lstViewPreComm.Items.Add("Type of comment                  Comment                         Date");
            lstViewPreComm.Items.Add("");


           /* Method obj = new Method();
            int comID = 0;
            var objCom = obj.getComment(comID);

          
            if (objCom == null)
            {
                msg = "No record was found in the data base, you didnt make any comment about our servince ";
                messageBox(msg);
            }
            else
            {
                while (objCom != null)
                {
                    lstViewPreComm.Items.Add(objCom.Name + "  " + objCom.Comment);
                    comID = comID + 1;
                    objCom = obj.getComment(comID);
                }
            }
            */
            
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

            getComment();
            string msg = "";
           


            Method obj = new Method();
            int comID = 0;
            var objCom = obj.getComment(comID);


            if (objCom == null)
            {
                msg = "No record was found in the data base, you didnt make any comment about our servince ";
                messageBox(msg);
            }
            else
            {
                while (objCom != null)
                {
                    lstViewPreComm.Items.Add(objCom.Name + "  " + objCom.Comment);
                    comID = comID + 1;
                    objCom = obj.getComment(comID);
                }
            }
            

        }
    }
}
