using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.Client;

namespace WinFormsApp1
{
    public partial class Sign : Form
    {
        public static ClientModel client;
        public static ClientStorage storage = new ClientStorage();
        public static Form Instance { get; private set; }
        public Sign()
        {
            Instance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //вход за менеджера
        {
            Manager_Interface F = new Manager_Interface();
            F.Show();
            Hide();
        }

        private void Sign_Button_Click(object sender, EventArgs e) //вход за клиента
        {
            if (S_Name.Text != "" && F_Name.Text != "" && T_Name.Text != "" && Date_Birth.Text != "" && Phone.Text != "")
            {
                client = new ClientModel()
                {
                    S_Name = S_Name.Text,
                    F_Name = F_Name.Text,
                    T_Name = T_Name.Text,
                    Date_Birth = Date_Birth.Text,
                    Phone = Phone.Text
                };
                storage.Add(client);
                storage.Save();
                Client_Interface F = new Client_Interface();
                F.Show();
                Hide();
            }
            else
            {
                label6.Text = "Заполните поля";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Phone.Text != "")
            {
                client = storage.Find(Phone.Text);
                Client_Interface F = new Client_Interface();
                F.Show();
                Hide();
            }
        }
    }
}
