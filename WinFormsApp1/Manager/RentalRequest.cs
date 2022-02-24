using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Manager
{
    public partial class RentalRequest : Form
    {
        public ContractStorage storage = new ContractStorage();
        public RentalRequest()
        {
            InitializeComponent();
            listBox1.Items.AddRange(storage.ToAccept.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.Accept(listBox1.SelectedItem as ContractModel);
            storage.Save();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(storage.ToAccept.ToArray());
        }
    }
}
