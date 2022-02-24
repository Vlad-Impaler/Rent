using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Client
{
    public partial class Contract : Form
    {
        public ContractStorage storage = new ContractStorage();
        public Contract()
        {
            InitializeComponent();
            listBox1.Items.AddRange(storage.ClientContracts(Sign.client.Phone).ToArray());
        }
    }
}
