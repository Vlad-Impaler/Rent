using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Manager
{
    public partial class RentalContract : Form
    {
        public ContractStorage storage = new ContractStorage();
        public RentalContract()
        {
            InitializeComponent();
            listBox1.Items.AddRange(storage.Accepts.ToArray());
        }
    }
}
