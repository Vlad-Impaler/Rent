using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Manager;

namespace WinFormsApp1
{
    public partial class Manager_Interface : Form
    {
        public Manager_Interface()
        {
            InitializeComponent();
        }

        private void Manager_Interface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sign.Instance.Close();
        }

        private void buttonAddFlat_Click(object sender, EventArgs e) //кнопка добавить квартиру
        {
            Add_Flat F = new Add_Flat();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clients_List F = new Clients_List();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentalRequest F = new RentalRequest();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RentalContract F = new RentalContract();
            F.Show();
        }
    }
}
