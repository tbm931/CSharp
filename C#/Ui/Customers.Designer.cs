namespace Ui
{
    partial class Customers
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
            label1 = new Label();
            tabControl1 = new TabControl();
            add = new TabPage();
            aidtxt = new TextBox();
            label8 = new Label();
            aadresstxt = new TextBox();
            aphonetxt = new TextBox();
            anametxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            addbtn = new Button();
            update = new TabPage();
            uidtxt = new TextBox();
            label9 = new Label();
            updatebtn = new Button();
            uadresstxt = new TextBox();
            uphonetxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            unamecmb = new ComboBox();
            delete = new TabPage();
            deletebtn = new Button();
            dcustomerscmb = new ComboBox();
            label14 = new Label();
            tabControl1.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "לקוחות";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(add);
            tabControl1.Controls.Add(update);
            tabControl1.Controls.Add(delete);
            tabControl1.Location = new Point(209, 113);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(497, 441);
            tabControl1.TabIndex = 2;
            // 
            // add
            // 
            add.Controls.Add(aidtxt);
            add.Controls.Add(label8);
            add.Controls.Add(aadresstxt);
            add.Controls.Add(aphonetxt);
            add.Controls.Add(anametxt);
            add.Controls.Add(label5);
            add.Controls.Add(label4);
            add.Controls.Add(label2);
            add.Controls.Add(addbtn);
            add.Location = new Point(4, 29);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Padding = new Padding(3, 4, 3, 4);
            add.RightToLeft = RightToLeft.Yes;
            add.Size = new Size(489, 408);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // aidtxt
            // 
            aidtxt.Location = new Point(67, 54);
            aidtxt.Name = "aidtxt";
            aidtxt.Size = new Size(137, 27);
            aidtxt.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 54);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 16;
            label8.Text = "ת\"ז:";
            // 
            // aadresstxt
            // 
            aadresstxt.Location = new Point(70, 240);
            aadresstxt.Name = "aadresstxt";
            aadresstxt.Size = new Size(137, 27);
            aadresstxt.TabIndex = 15;
            // 
            // aphonetxt
            // 
            aphonetxt.Location = new Point(70, 174);
            aphonetxt.Name = "aphonetxt";
            aphonetxt.Size = new Size(137, 27);
            aphonetxt.TabIndex = 14;
            // 
            // anametxt
            // 
            anametxt.Location = new Point(67, 108);
            anametxt.Name = "anametxt";
            anametxt.Size = new Size(137, 27);
            anametxt.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 243);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "כתובת:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 177);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "טלפון:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 115);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "שם:";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(217, 323);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(86, 31);
            addbtn.TabIndex = 0;
            addbtn.Text = "הוסף";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += Addbtn_Click;
            // 
            // update
            // 
            update.Controls.Add(uidtxt);
            update.Controls.Add(label9);
            update.Controls.Add(updatebtn);
            update.Controls.Add(uadresstxt);
            update.Controls.Add(uphonetxt);
            update.Controls.Add(label7);
            update.Controls.Add(label6);
            update.Controls.Add(label3);
            update.Controls.Add(unamecmb);
            update.Location = new Point(4, 29);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Padding = new Padding(3, 4, 3, 4);
            update.Size = new Size(489, 408);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // uidtxt
            // 
            uidtxt.Location = new Point(53, 68);
            uidtxt.Name = "uidtxt";
            uidtxt.Size = new Size(137, 27);
            uidtxt.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 68);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 7;
            label9.Text = "ת\"ז:";
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(208, 335);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(94, 29);
            updatebtn.TabIndex = 6;
            updatebtn.Text = "עדכן";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += Updatebtn_Click;
            // 
            // uadresstxt
            // 
            uadresstxt.Location = new Point(53, 264);
            uadresstxt.Name = "uadresstxt";
            uadresstxt.Size = new Size(137, 27);
            uadresstxt.TabIndex = 5;
            // 
            // uphonetxt
            // 
            uphonetxt.Location = new Point(53, 197);
            uphonetxt.Name = "uphonetxt";
            uphonetxt.Size = new Size(137, 27);
            uphonetxt.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 264);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 3;
            label7.Text = "כתובת:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 197);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 2;
            label6.Text = "טלפון:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 131);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 1;
            label3.Text = "שם:";
            // 
            // unamecmb
            // 
            unamecmb.FormattingEnabled = true;
            unamecmb.Location = new Point(53, 126);
            unamecmb.Name = "unamecmb";
            unamecmb.Size = new Size(137, 28);
            unamecmb.TabIndex = 0;
            unamecmb.SelectedValueChanged += unamecmb_SelectedValueChanged;
            // 
            // delete
            // 
            delete.Controls.Add(deletebtn);
            delete.Controls.Add(dcustomerscmb);
            delete.Controls.Add(label14);
            delete.Location = new Point(4, 29);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(489, 408);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(217, 257);
            deletebtn.Margin = new Padding(3, 4, 3, 4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(86, 31);
            deletebtn.TabIndex = 21;
            deletebtn.Text = "מחק";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += Deletebtn_Click;
            // 
            // dcustomerscmb
            // 
            dcustomerscmb.FormattingEnabled = true;
            dcustomerscmb.Location = new Point(43, 123);
            dcustomerscmb.Margin = new Padding(3, 4, 3, 4);
            dcustomerscmb.Name = "dcustomerscmb";
            dcustomerscmb.Size = new Size(138, 28);
            dcustomerscmb.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(358, 127);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 19;
            label14.Text = "בחר לקוח:";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            Text = "Customers";
            tabControl1.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage add;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button addbtn;
        private TabPage update;
        private TabPage delete;
        private Button deletebtn;
        private Label label14;
        private TextBox anametxt;
        private TextBox aadresstxt;
        private TextBox aphonetxt;
        private ComboBox unamecmb;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox uadresstxt;
        private TextBox uphonetxt;
        private Button updatebtn;
        private TextBox aidtxt;
        private Label label8;
        private TextBox uidtxt;
        private Label label9;
        private ComboBox dcustomerscmb;
    }
}