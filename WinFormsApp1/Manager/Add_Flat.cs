using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1.Manager
{
    public partial class Add_Flat : Form
    {
        public static FlatStorage storage = new FlatStorage();
        public Add_Flat()
        {
            InitializeComponent();
        }

        private void buttonAddFlat_Click(object sender, EventArgs e)
        {
            FlatModel flat;
            if (Adres.Text != "" && Area.Text != "" && Rooms.Text != "" && Price.Text != "" && Detail.Text != "")
            {
                flat = new FlatModel()
                {
                    Adres = Adres.Text,
                    Area = Area.Text,
                    Rooms = Rooms.Text,
                    Price = Price.Text,
                    Detail = Detail.Text,
                };
                storage.Add(flat);
                storage.Save();
                Close();
            }
            else
            {
                label6.Text = "Заполните поля";
            }
        }
    }
}
