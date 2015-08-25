using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Mobile_App.Class
{
   public class tblComplains
    {

            [PrimaryKey, AutoIncrement]
       public int complainID { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Comment { get; set; }
        public string complainOrcompliment { get; set; }
        public string ComDate { get; set; }

    }
}
