namespace Caver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage4 = new TabPage();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            textBoxZipcode = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxNo = new CheckBox();
            checkBoxYes = new CheckBox();
            comboBoxLicenseType = new ComboBox();
            textBoxHouseNum = new TextBox();
            textBoxStreet = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastname = new TextBox();
            textBoxFirstname = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1761, 1004);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1753, 976);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1753, 976);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Prospects";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(6, 6);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1741, 964);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1733, 936);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Prospects";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1651, 880);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(textBoxZipcode);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(checkBoxNo);
            tabPage4.Controls.Add(checkBoxYes);
            tabPage4.Controls.Add(comboBoxLicenseType);
            tabPage4.Controls.Add(textBoxHouseNum);
            tabPage4.Controls.Add(textBoxStreet);
            tabPage4.Controls.Add(textBoxPhone);
            tabPage4.Controls.Add(textBoxEmail);
            tabPage4.Controls.Add(textBoxLastname);
            tabPage4.Controls.Add(textBoxFirstname);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1733, 936);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Add new Prospect";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(240, 427);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 375);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 18;
            label9.Text = "Handicap Vechcle";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 310);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 17;
            label8.Text = "Licence Type";
            // 
            // textBoxZipcode
            // 
            textBoxZipcode.Location = new Point(97, 265);
            textBoxZipcode.Name = "textBoxZipcode";
            textBoxZipcode.Size = new Size(73, 23);
            textBoxZipcode.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 247);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 15;
            label7.Text = "Zipcode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 191);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 14;
            label6.Text = "num.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 191);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 13;
            label5.Text = "Street Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 138);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 12;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 82);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 11;
            label3.Text = "Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 36);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Firstname";
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(145, 393);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(42, 19);
            checkBoxNo.TabIndex = 8;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxYes
            // 
            checkBoxYes.AutoSize = true;
            checkBoxYes.Location = new Point(96, 393);
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.Size = new Size(43, 19);
            checkBoxYes.TabIndex = 7;
            checkBoxYes.Text = "Yes";
            checkBoxYes.UseVisualStyleBackColor = true;
            checkBoxYes.CheckedChanged += checkBoxYes_CheckedChanged;
            // 
            // comboBoxLicenseType
            // 
            comboBoxLicenseType.FormattingEnabled = true;
            comboBoxLicenseType.Location = new Point(95, 328);
            comboBoxLicenseType.Name = "comboBoxLicenseType";
            comboBoxLicenseType.Size = new Size(121, 23);
            comboBoxLicenseType.TabIndex = 6;
            // 
            // textBoxHouseNum
            // 
            textBoxHouseNum.Location = new Point(268, 209);
            textBoxHouseNum.Name = "textBoxHouseNum";
            textBoxHouseNum.Size = new Size(47, 23);
            textBoxHouseNum.TabIndex = 5;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(96, 209);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(149, 23);
            textBoxStreet.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(96, 156);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(171, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(96, 100);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(219, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(215, 54);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(100, 23);
            textBoxLastname.TabIndex = 1;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(96, 54);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(100, 23);
            textBoxFirstname.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1761, 1003);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private TextBox textBoxHouseNum;
        private TextBox textBoxStreet;
        private ComboBox comboBoxLicenseType;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxYes;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label9;
        private Label label8;
        private TextBox textBoxZipcode;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}