
namespace WinFormsApp1
{
    partial class Client_Interface
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
            this.List_Flat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.stBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // List_Flat
            // 
            this.List_Flat.FormattingEnabled = true;
            this.List_Flat.ItemHeight = 20;
            this.List_Flat.Location = new System.Drawing.Point(12, 54);
            this.List_Flat.Name = "List_Flat";
            this.List_Flat.Size = new System.Drawing.Size(776, 244);
            this.List_Flat.TabIndex = 1;
            this.List_Flat.SelectedIndexChanged += new System.EventHandler(this.List_Flat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Квартиры";
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(531, 387);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(116, 51);
            this.buttonRent.TabIndex = 5;
            this.buttonRent.Text = "Арендовать";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Договор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(12, 346);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(116, 27);
            this.gradeBox.TabIndex = 17;
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(12, 388);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(116, 51);
            this.buttonGrade.TabIndex = 18;
            this.buttonGrade.Text = "Оценить";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // stBox
            // 
            this.stBox.AutoSize = true;
            this.stBox.Location = new System.Drawing.Point(531, 319);
            this.stBox.Name = "stBox";
            this.stBox.Size = new System.Drawing.Size(74, 24);
            this.stBox.TabIndex = 19;
            this.stBox.Text = "Статус";
            this.stBox.UseVisualStyleBackColor = true;
            this.stBox.CheckedChanged += new System.EventHandler(this.stBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(531, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 20;
            // 
            // Client_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stBox);
            this.Controls.Add(this.buttonGrade);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Flat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_Interface_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Flat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.CheckBox stBox;
        private System.Windows.Forms.Label label3;
    }
}