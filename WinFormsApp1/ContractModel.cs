using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class ContractModel
    {
        public ClientModel Client { get; set; }
        public FlatModel Flat { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public int TotalPrice { get; set; }
        public bool Accept { get; set; }

        override
        public String ToString()
        {
            return $"Клиент: {this.Client}. Квартира: {this.Flat}. Аренда с {this.DateStart} по {this.DateEnd}, стоимость {this.TotalPrice}";
        }
    }
}
