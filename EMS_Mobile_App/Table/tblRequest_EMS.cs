using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Mobile_App.table
{
  public  class tblRequest_EMS
    {

        [PrimaryKey, AutoIncrement]
        public int RequestID { get; set; }

        public string DateTime { get; set; }
        public string Names { get; set; }
        public string Location { get; set; }
        public string IDNumber { get; set; }
        public string Status { set; get; }
    }
}
