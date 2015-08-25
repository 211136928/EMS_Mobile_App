using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Mobile_App.Table
{
  public  class tblLogIn
    {
               [PrimaryKey]
        public string Username { get; set; }

        public string Password { get; set; }
      
        public string ID { get; set; }


   
    }
}
