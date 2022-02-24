using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Client;
using WinFormsApp1.Manager;

namespace WinFormsApp1
{
    public partial class Client_Interface : Form
    {
        public static FlatModel flat;
        private FlatStorage storage = Add_Flat.storage;
        public Client_Interface()
        {
            InitializeComponent();
            Check();
            List_Flat.Items.AddRange(storage.Flats.ToArray());
        }

        private void Client_Interface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sign.Instance.Close();
        }

        public void Check() //проверка выделения
        {
            var model = List_Flat.SelectedItem as FlatModel;
            if (model is null)
            {
                buttonGrade.Enabled = false;
                buttonRent.Enabled = false;
                stBox.Checked = false;
            }
            else
            {
                flat = model;
                buttonGrade.Enabled = true;
                buttonRent.Enabled = true;
                stBox.Checked = model.Chk;
            }
        }

        public void RefreshList() //обновление
        {
            List_Flat.Items.Clear();
            List_Flat.Items.AddRange(storage.Flats.ToArray());
            Check();
        }

        private void buttonGrade_Click(object sender, EventArgs e) //подсчет средней оценки
        {
            var model = List_Flat.SelectedItem as FlatModel;
            if (model.K == 0)
            {
                model.Grade = float.Parse(gradeBox.Text);
                model.K++;
            }
            else
            {
                model.Grade = (model.Grade + float.Parse(gradeBox.Text) * model.K) / (model.K + 1);
                model.K++;
            }
            storage.Save();
            RefreshList();
            gradeBox.Text = "";
        }

        private void List_Flat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (stBox.Checked == true)
            {
                Rental F = new Rental();
                F.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contract F = new Contract();
            F.Show();
        }

        private void stBox_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
