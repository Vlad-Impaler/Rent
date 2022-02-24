using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class FlatModel
    {
        public string Adres { get; set; }
        public string Area { get; set; }
        public string Rooms { get; set; }
        public string Price { get; set; }
        public string Detail { get; set; }
        public float Grade { get; set; }
        public int K { get; set; }
        public bool Chk { get; set; } = true;

        override
        public String ToString()
        {
            return $"Адрес: {this.Adres}; Площадь: {this.Area}, Комнат: {this.Rooms}, Стоимость: {this.Price}; Описание: {this.Detail}; Оценка: {this.Grade}";
        }
    }
}
