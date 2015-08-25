using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Mobile_App.Table
{
   public class tblRegister
    {


        [PrimaryKey]
        public string ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    
        public string CellNum { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
       



    }
}
