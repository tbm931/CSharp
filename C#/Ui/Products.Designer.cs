namespace Ui
{
    partial class Products
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
            anametxt = new TextBox();
            apricenud = new NumericUpDown();
            label5 = new Label();
            acategorycmb = new ComboBox();
            acntnud = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            addbtn = new Button();
            update = new TabPage();
            uproductcmb = new ComboBox();
            upricenud = new NumericUpDown();
            label6 = new Label();
            ucategorycmb = new ComboBox();
            ucntnud = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            updatebtn = new Button();
            delete = new TabPage();
            deletebtn = new Button();
            dproductscmb = new ComboBox();
            label14 = new Label();
            tabControl1.SuspendLayout();
            add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)apricenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acntnud).BeginInit();
            update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upricenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucntnud).BeginInit();
            delete.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "מוצרים";
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
            add.Controls.Add(anametxt);
            add.Controls.Add(apricenud);
            add.Controls.Add(label5);
            add.Controls.Add(acategorycmb);
            add.Controls.Add(acntnud);
            add.Controls.Add(label4);
            add.Controls.Add(label3);
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
            // anametxt
            // 
            anametxt.Location = new Point(43, 52);
            anametxt.Name = "anametxt";
            anametxt.Size = new Size(138, 27);
            anametxt.TabIndex = 26;
            // 
            // apricenud
            // 
            apricenud.Location = new Point(43, 168);
            apricenud.Margin = new Padding(3, 4, 3, 4);
            apricenud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            apricenud.Name = "apricenud";
            apricenud.Size = new Size(137, 27);
            apricenud.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 231);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 19;
            label5.Text = "בחר קטגוריה:";
            // 
            // acategorycmb
            // 
            acategorycmb.FormattingEnabled = true;
            acategorycmb.Location = new Point(45, 228);
            acategorycmb.Margin = new Padding(3, 4, 3, 4);
            acategorycmb.Name = "acategorycmb";
            acategorycmb.Size = new Size(138, 28);
            acategorycmb.TabIndex = 18;
            // 
            // acntnud
            // 
            acntnud.Location = new Point(44, 111);
            acntnud.Margin = new Padding(3, 4, 3, 4);
            acntnud.Name = "acntnud";
            acntnud.Size = new Size(137, 27);
            acntnud.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 175);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 16;
            label4.Text = "מחיר:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 113);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 15;
            label3.Text = "כמות פריטים:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 52);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "שם מוצר:";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(191, 330);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(86, 31);
            addbtn.TabIndex = 13;
            addbtn.Text = "הוסף";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += Addbtn_Click;
            // 
            // update
            // 
            update.Controls.Add(uproductcmb);
            update.Controls.Add(upricenud);
            update.Controls.Add(label6);
            update.Controls.Add(ucategorycmb);
            update.Controls.Add(ucntnud);
            update.Controls.Add(label7);
            update.Controls.Add(label8);
            update.Controls.Add(label9);
            update.Controls.Add(updatebtn);
            update.Location = new Point(4, 29);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Padding = new Padding(3, 4, 3, 4);
            update.Size = new Size(489, 408);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // uproductcmb
            // 
            uproductcmb.FormattingEnabled = true;
            uproductcmb.Location = new Point(54, 50);
            uproductcmb.Name = "uproductcmb";
            uproductcmb.Size = new Size(136, 28);
            uproductcmb.TabIndex = 35;
            uproductcmb.SelectedValueChanged += Uproductcmb_SelectedValueChanged;
            // 
            // upricenud
            // 
            upricenud.Location = new Point(52, 166);
            upricenud.Margin = new Padding(3, 4, 3, 4);
            upricenud.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            upricenud.Name = "upricenud";
            upricenud.Size = new Size(137, 27);
            upricenud.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 229);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 33;
            label6.Text = "בחר קטגוריה:";
            // 
            // ucategorycmb
            // 
            ucategorycmb.FormattingEnabled = true;
            ucategorycmb.Location = new Point(54, 226);
            ucategorycmb.Margin = new Padding(3, 4, 3, 4);
            ucategorycmb.Name = "ucategorycmb";
            ucategorycmb.Size = new Size(138, 28);
            ucategorycmb.TabIndex = 32;
            // 
            // ucntnud
            // 
            ucntnud.Location = new Point(53, 109);
            ucntnud.Margin = new Padding(3, 4, 3, 4);
            ucntnud.Name = "ucntnud";
            ucntnud.Size = new Size(137, 27);
            ucntnud.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 173);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 30;
            label7.Text = "מחיר:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 111);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 29;
            label8.Text = "כמות פריטים:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 50);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 28;
            label9.Text = "בחר מוצר:";
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(200, 328);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(86, 31);
            updatebtn.TabIndex = 27;
            updatebtn.Text = "עדכן";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += Updatebtn_Click;
            // 
            // delete
            // 
            delete.Controls.Add(deletebtn);
            delete.Controls.Add(dproductscmb);
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
            // dproductscmb
            // 
            dproductscmb.FormattingEnabled = true;
            dproductscmb.Location = new Point(43, 123);
            dproductscmb.Margin = new Padding(3, 4, 3, 4);
            dproductscmb.Name = "dproductscmb";
            dproductscmb.Size = new Size(138, 28);
            dproductscmb.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(358, 127);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 19;
            label14.Text = "בחר מוצר:";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Products";
            Text = "Products";
            tabControl1.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)apricenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)acntnud).EndInit();
            update.ResumeLayout(false);
            update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upricenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucntnud).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage add;
        private TabPage update;
        private TabPage delete;
        private Button deletebtn;
        private ComboBox dproductscmb;
        private Label label14;
        private TextBox anametxt;
        private NumericUpDown apricenud;
        private Label label5;
        private ComboBox acategorycmb;
        private NumericUpDown acntnud;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addbtn;
        private NumericUpDown upricenud;
        private Label label6;
        private ComboBox ucategorycmb;
        private NumericUpDown ucntnud;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button updatebtn;
        private ComboBox uproductcmb;
    }
}