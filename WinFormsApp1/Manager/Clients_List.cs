using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Client;

namespace WinFormsApp1.Manager
{
    public partial class Clients_List : Form
    {
        private ClientStorage storage = Sign.storage;
        public Clients_List()
        {
            InitializeComponent();
            listBox1.Items.AddRange(storage.Clients.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.Ban(listBox1.SelectedItem as ClientModel);
            storage.Save();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
