using EMS_Mobile_App.Class;
using EMS_Mobile_App.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using EMS_Mobile_App.table;

namespace EMS_Mobile_App.Class
{
   public class Method
    {

       private EMS_Mobile_App.App app = (Application.Current as App);



       private void setLogIn(string pword, string userName,string id)
       {

           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               int success = db.Insert(new tblLogIn()
               {
                  ID = id,
                  Username = userName,
                  Password = pword,
               });
           }

       }

       //get user from table register by using ID number 
       public tblRegister getMember(string ID)
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var _mem = db.Query<tblRegister>("Select * from User Where username ='" + ID + "' ").FirstOrDefault();
               return _mem;

           }
       }


       // registration method
       public void setRegister(string IDnum, string name, string surname, string email,string cell, string gender, int age, string password)
       {

           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               int success = db.Insert(new tblRegister()
               {
                   ID = IDnum,
                   Name = name,
                   Surname = surname,
                   Email = email,
                   Gender = gender,
                   Age = age,
                   Province = "Gua",
               });
             
           }
           setLogIn(password, email, IDnum);

       }
       public tblRegister getRegisterUser(string ID)
       {
                 using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var _mem = db.Query<tblRegister>("Select *  from tblRegister Where ID ='" + ID + "' ").FirstOrDefault();
               return _mem;

           }
       }
       //this method return an object of registered user using email
       public tblRegister getRegUser(string name)
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var _mem = db.Query<tblRegister>("Select *  from tblRegister Where Name ='" +name + "' ").FirstOrDefault();
               return _mem;

           }
       }

       // this method will set complains and compliment in database


       public void setComplains(int cID ,string id, string name, string surname, string email, string comment, string comORcompli)
       {
           string  date = DateTime.Now.ToString();
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               int success = db.Insert(new tblComplains()
               {
                complainID = 0,
                 ID = id,
                 Name = name,
                 Email = email,
                 Surname = surname,
                 Comment = comment,
                 complainOrcompliment = comORcompli,
                 ComDate = date,
                 
               });
           }

       }

       // this method will retrieve all complains and compliment made by user
       public tblComplains getComment(int id)
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var allCom = db.Query<tblComplains>("Select * from tblComplains where complainID = '"+id+"'").FirstOrDefault(); 
               return allCom;

           }

       }


       //this method will get the user log in details
       public tblLogIn getLogIN(string email, string pass)
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var logIn = db.Query<tblLogIn>("Select * from tblLogIn Where Username ='" + email + "' AND Password = '" + pass + "'").FirstOrDefault();
               return logIn;

           }
       }


       // this method udate user details 
       public void updateDetails(string surname, string cell, string email, string homeAddress, string id)
       {

           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var updateLogin = db.Query<tblLogIn>("update tblLogIn set Username ='" + email + "' where ID = '" + id + "'").FirstOrDefault();

               var details = db.Query<tblRegister>("update tblRegister set Surname = '"+surname+"' where ID = '"+id+"' ").FirstOrDefault();

           }
       }



       //this method will reset passwod 
       public void resetPassword(string id, string password)
       {

           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var updateLogin = db.Query<tblLogIn>("update tblLogIn set Passowrd ='" + password + "' where ID = '" + id + "'").FirstOrDefault();
           }
       }
       

       //this method will insert values in table request ems

       public void setRequestValue(int R_ID, string location,string status, string userId, string names )
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               int success = db.Insert(new tblRequest_EMS()
               {
                  
                RequestID = R_ID,
                Location = location,
                Status = status,
                IDNumber = userId,
                Names = names,
               });

           }

       }

       // THIS METHOD WILL RETURN AN OBJECT O tlbRequest_EMS

       public tblRequest_EMS getALLRequest(string email, string pass)
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var r_ems = db.Query<tblRequest_EMS>("Select * from tblRequest_EMS").FirstOrDefault();
               return r_ems;

           }
       }


    }


}
