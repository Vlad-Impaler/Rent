
namespace WinFormsApp1.Manager
{
    partial class Add_Flat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddFlat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rooms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddFlat
            // 
            this.buttonAddFlat.Location = new System.Drawing.Point(739, 412);
            this.buttonAddFlat.Name = "buttonAddFlat";
            this.buttonAddFlat.Size = new System.Drawing.Size(152, 52);
            this.buttonAddFlat.TabIndex = 0;
            this.buttonAddFlat.Text = "Добавить";
            this.buttonAddFlat.UseVisualStyleBackColor = true;
            this.buttonAddFlat.Click += new System.EventHandler(this.buttonAddFlat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(47, 69);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(844, 27);
            this.Adres.TabIndex = 2;
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(47, 154);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(179, 27);
            this.Area.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь, м^2";
            // 
            // Rooms
            // 
            this.Rooms.Location = new System.Drawing.Point(279, 154);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(179, 27);
            this.Rooms.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во комнат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Стоимость, сут/р";
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(47, 240);
            this.Detail.Multiline = true;
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(844, 138);
            this.Detail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(511, 154);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(179, 27);
            this.Price.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(47, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 13;
            // 
            // Add_Flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddFlat);
            this.Name = "Add_Flat";
            this.Text = "Добавить квартиру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
    }
}