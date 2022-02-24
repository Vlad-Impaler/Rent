using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Client
{
    public partial class Rental : Form
    {
        public static ContractStorage storage = new ContractStorage();
        public Rental()
        {
            InitializeComponent();
            Check();
        }

        public void Check() //Подтверждение
        {
            if (checkBox1.Checked != false)
            {
                button1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                ContractModel contract = new ContractModel()
                {
                    Client = Sign.client,
                    Flat = Client_Interface.flat,
                    DateStart = textBox1.Text,
                    DateEnd = textBox2.Text,
                    TotalPrice = int.Parse(textBox4.Text)
                };
                storage.Add(contract);
                storage.Save();
                Close();
            }
            else
            {
                label5.Text = "Заполните поля";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out var days);
            textBox4.Text = (days * int.Parse(Client_Interface.flat.Price)).ToString();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
