﻿namespace SAW_Create_Client
{
    partial class DatabaseSetup
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
            this.Evo_Server_Name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Com_Server_Name = new System.Windows.Forms.ComboBox();
            this.Evo_Server_User_Name = new System.Windows.Forms.TextBox();
            this.Evo_Server_Password = new System.Windows.Forms.TextBox();
            this.Com_Server_User_Name = new System.Windows.Forms.TextBox();
            this.Com_Server_Password = new System.Windows.Forms.TextBox();
            this.Evo_Company_Databases = new System.Windows.Forms.ComboBox();
            this.Common_Databases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Evo_Server_Name
            // 
            this.Evo_Server_Name.FormattingEnabled = true;
            this.Evo_Server_Name.Location = new System.Drawing.Point(139, 48);
            this.Evo_Server_Name.Name = "Evo_Server_Name";
            this.Evo_Server_Name.Size = new System.Drawing.Size(243, 21);
            this.Evo_Server_Name.TabIndex = 0;
            this.Evo_Server_Name.SelectedIndexChanged += new System.EventHandler(this.Evo_Server_Name_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Com_Server_Name
            // 
            this.Com_Server_Name.FormattingEnabled = true;
            this.Com_Server_Name.ItemHeight = 13;
            this.Com_Server_Name.Location = new System.Drawing.Point(139, 206);
            this.Com_Server_Name.Name = "Com_Server_Name";
            this.Com_Server_Name.Size = new System.Drawing.Size(243, 21);
            this.Com_Server_Name.TabIndex = 4;
            // 
            // Evo_Server_User_Name
            // 
            this.Evo_Server_User_Name.Location = new System.Drawing.Point(139, 75);
            this.Evo_Server_User_Name.Name = "Evo_Server_User_Name";
            this.Evo_Server_User_Name.Size = new System.Drawing.Size(243, 20);
            this.Evo_Server_User_Name.TabIndex = 1;
            // 
            // Evo_Server_Password
            // 
            this.Evo_Server_Password.Location = new System.Drawing.Point(139, 101);
            this.Evo_Server_Password.Name = "Evo_Server_Password";
            this.Evo_Server_Password.Size = new System.Drawing.Size(243, 20);
            this.Evo_Server_Password.TabIndex = 2;
            this.Evo_Server_Password.Leave += new System.EventHandler(this.Evo_Server_Password_Leave);
            // 
            // Com_Server_User_Name
            // 
            this.Com_Server_User_Name.Location = new System.Drawing.Point(139, 233);
            this.Com_Server_User_Name.Name = "Com_Server_User_Name";
            this.Com_Server_User_Name.Size = new System.Drawing.Size(243, 20);
            this.Com_Server_User_Name.TabIndex = 5;
            // 
            // Com_Server_Password
            // 
            this.Com_Server_Password.Location = new System.Drawing.Point(139, 259);
            this.Com_Server_Password.Name = "Com_Server_Password";
            this.Com_Server_Password.Size = new System.Drawing.Size(243, 20);
            this.Com_Server_Password.TabIndex = 6;
            this.Com_Server_Password.Leave += new System.EventHandler(this.Com_Server_Password_Leave);
            // 
            // Evo_Company_Databases
            // 
            this.Evo_Company_Databases.FormattingEnabled = true;
            this.Evo_Company_Databases.ItemHeight = 13;
            this.Evo_Company_Databases.Location = new System.Drawing.Point(139, 127);
            this.Evo_Company_Databases.Name = "Evo_Company_Databases";
            this.Evo_Company_Databases.Size = new System.Drawing.Size(243, 21);
            this.Evo_Company_Databases.TabIndex = 3;
            // 
            // Common_Databases
            // 
            this.Common_Databases.FormattingEnabled = true;
            this.Common_Databases.Location = new System.Drawing.Point(139, 285);
            this.Common_Databases.Name = "Common_Databases";
            this.Common_Databases.Size = new System.Drawing.Size(243, 21);
            this.Common_Databases.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Evolution Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Evolution Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 151);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evolution Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 151);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common Database";
            // 
            // DatabaseSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Common_Databases);
            this.Controls.Add(this.Evo_Company_Databases);
            this.Controls.Add(this.Com_Server_Password);
            this.Controls.Add(this.Com_Server_User_Name);
            this.Controls.Add(this.Evo_Server_Password);
            this.Controls.Add(this.Evo_Server_User_Name);
            this.Controls.Add(this.Com_Server_Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Evo_Server_Name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DatabaseSetup";
            this.Text = "Allocate Database";
            this.Load += new System.EventHandler(this.DatabaseSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Evo_Server_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Com_Server_Name;
        private System.Windows.Forms.TextBox Evo_Server_User_Name;
        private System.Windows.Forms.TextBox Evo_Server_Password;
        private System.Windows.Forms.TextBox Com_Server_User_Name;
        private System.Windows.Forms.TextBox Com_Server_Password;
        private System.Windows.Forms.ComboBox Evo_Company_Databases;
        private System.Windows.Forms.ComboBox Common_Databases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}