using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class ClientModel
    {
        public string S_Name { get; set; }
        public string F_Name { get; set; }
        public string T_Name { get; set; }
        public string Date_Birth { get; set; }
        public string Phone { get; set; }

        override
        public String ToString()
        {
            return $"{this.S_Name} {this.F_Name} {this.T_Name}, родился {this.Date_Birth}, телефон {this.Phone}";
        }
    }
}
