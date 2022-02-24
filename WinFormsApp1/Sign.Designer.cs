
namespace WinFormsApp1
{
    partial class Sign
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
            this.label1 = new System.Windows.Forms.Label();
            this.S_Name = new System.Windows.Forms.TextBox();
            this.Sign_Button = new System.Windows.Forms.Button();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.Date_Birth = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // S_Name
            // 
            this.S_Name.Location = new System.Drawing.Point(78, 65);
            this.S_Name.Name = "S_Name";
            this.S_Name.Size = new System.Drawing.Size(269, 27);
            this.S_Name.TabIndex = 1;
            // 
            // Sign_Button
            // 
            this.Sign_Button.Location = new System.Drawing.Point(78, 430);
            this.Sign_Button.Name = "Sign_Button";
            this.Sign_Button.Size = new System.Drawing.Size(269, 29);
            this.Sign_Button.TabIndex = 2;
            this.Sign_Button.Text = "Вход";
            this.Sign_Button.UseVisualStyleBackColor = true;
            this.Sign_Button.Click += new System.EventHandler(this.Sign_Button_Click);
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(78, 125);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(269, 27);
            this.F_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // T_Name
            // 
            this.T_Name.Location = new System.Drawing.Point(78, 185);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(269, 27);
            this.T_Name.TabIndex = 6;
            // 
            // Date_Birth
            // 
            this.Date_Birth.Location = new System.Drawing.Point(78, 245);
            this.Date_Birth.Name = "Date_Birth";
            this.Date_Birth.Size = new System.Drawing.Size(269, 27);
            this.Date_Birth.TabIndex = 8;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(78, 305);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(269, 27);
            this.Phone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Телефон";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Войти как менеджер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(78, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 15;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Date_Birth);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sign_Button);
            this.Controls.Add(this.S_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox S_Name;
        private System.Windows.Forms.Button Sign_Button;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_Name;
        private System.Windows.Forms.TextBox Date_Birth;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}