namespace Ui
{
    partial class Sales
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
            tabControl1 = new TabControl();
            add = new TabPage();
            aenddate = new DateTimePicker();
            abegindate = new DateTimePicker();
            label7 = new Label();
            apricenud = new NumericUpDown();
            apreferednud = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            aproductscmb = new ComboBox();
            amincntnud = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            addbtn = new Button();
            update = new TabPage();
            uenddate = new DateTimePicker();
            ubegindate = new DateTimePicker();
            label8 = new Label();
            upricenud = new NumericUpDown();
            upreferedcb = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            upsalecmb = new ComboBox();
            umincntnud = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            updatebtn = new Button();
            delete = new TabPage();
            deletebtn = new Button();
            dproductscmb = new ComboBox();
            label14 = new Label();
            label1 = new Label();
            allSales = new TabPage();
            allSaleslb = new ListBox();
            tabControl1.SuspendLayout();
            add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)apricenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amincntnud).BeginInit();
            update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upricenud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umincntnud).BeginInit();
            delete.SuspendLayout();
            allSales.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(add);
            tabControl1.Controls.Add(update);
            tabControl1.Controls.Add(delete);
            tabControl1.Controls.Add(allSales);
            tabControl1.Location = new Point(189, 91);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(435, 331);
            tabControl1.TabIndex = 0;
            // 
            // add
            // 
            add.Controls.Add(aenddate);
            add.Controls.Add(abegindate);
            add.Controls.Add(label7);
            add.Controls.Add(apricenud);
            add.Controls.Add(apreferednud);
            add.Controls.Add(label6);
            add.Controls.Add(label5);
            add.Controls.Add(aproductscmb);
            add.Controls.Add(amincntnud);
            add.Controls.Add(label4);
            add.Controls.Add(label3);
            add.Controls.Add(label2);
            add.Controls.Add(addbtn);
            add.Location = new Point(4, 24);
            add.Name = "add";
            add.Padding = new Padding(3, 3, 3, 3);
            add.RightToLeft = RightToLeft.Yes;
            add.Size = new Size(427, 303);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // aenddate
            // 
            aenddate.Location = new Point(61, 198);
            aenddate.Name = "aenddate";
            aenddate.Size = new Size(120, 23);
            aenddate.TabIndex = 12;
            // 
            // abegindate
            // 
            abegindate.Location = new Point(61, 164);
            abegindate.Name = "abegindate";
            abegindate.Size = new Size(120, 23);
            abegindate.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 203);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 10;
            label7.Text = "תאריך סיום המבצע:";
            // 
            // apricenud
            // 
            apricenud.Location = new Point(61, 107);
            apricenud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            apricenud.Name = "apricenud";
            apricenud.Size = new Size(120, 23);
            apricenud.TabIndex = 9;
            // 
            // apreferednud
            // 
            apreferednud.AutoSize = true;
            apreferednud.Location = new Point(111, 138);
            apreferednud.Name = "apreferednud";
            apreferednud.Size = new Size(15, 14);
            apreferednud.TabIndex = 8;
            apreferednud.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 138);
            label6.Name = "label6";
            label6.Size = new Size(156, 15);
            label6.TabIndex = 7;
            label6.Text = "המבצע רק ללקוחות המועדון?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 172);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 6;
            label5.Text = "תאריך תחילת המבצע:";
            // 
            // aproductscmb
            // 
            aproductscmb.FormattingEnabled = true;
            aproductscmb.Location = new Point(61, 31);
            aproductscmb.Name = "aproductscmb";
            aproductscmb.Size = new Size(121, 23);
            aproductscmb.TabIndex = 5;
            // 
            // amincntnud
            // 
            amincntnud.Location = new Point(61, 66);
            amincntnud.Name = "amincntnud";
            amincntnud.Size = new Size(120, 23);
            amincntnud.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 105);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "מחיר במבצע:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 68);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "כמות פריטים מינימלית:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "בחר מוצר:";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(190, 242);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 0;
            addbtn.Text = "הוסף";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += Addbtn_Click;
            // 
            // update
            // 
            update.Controls.Add(uenddate);
            update.Controls.Add(ubegindate);
            update.Controls.Add(label8);
            update.Controls.Add(upricenud);
            update.Controls.Add(upreferedcb);
            update.Controls.Add(label9);
            update.Controls.Add(label10);
            update.Controls.Add(upsalecmb);
            update.Controls.Add(umincntnud);
            update.Controls.Add(label11);
            update.Controls.Add(label12);
            update.Controls.Add(label13);
            update.Controls.Add(updatebtn);
            update.Location = new Point(4, 24);
            update.Name = "update";
            update.Padding = new Padding(3, 3, 3, 3);
            update.Size = new Size(427, 303);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // uenddate
            // 
            uenddate.Location = new Point(46, 201);
            uenddate.Name = "uenddate";
            uenddate.Size = new Size(120, 23);
            uenddate.TabIndex = 25;
            // 
            // ubegindate
            // 
            ubegindate.Location = new Point(46, 167);
            ubegindate.Name = "ubegindate";
            ubegindate.Size = new Size(120, 23);
            ubegindate.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 207);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 23;
            label8.Text = "תאריך סיום המבצע:";
            // 
            // upricenud
            // 
            upricenud.Location = new Point(46, 110);
            upricenud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            upricenud.Name = "upricenud";
            upricenud.Size = new Size(120, 23);
            upricenud.TabIndex = 22;
            // 
            // upreferedcb
            // 
            upreferedcb.AutoSize = true;
            upreferedcb.Location = new Point(96, 141);
            upreferedcb.Name = "upreferedcb";
            upreferedcb.Size = new Size(15, 14);
            upreferedcb.TabIndex = 21;
            upreferedcb.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 140);
            label9.Name = "label9";
            label9.Size = new Size(156, 15);
            label9.TabIndex = 20;
            label9.Text = "המבצע רק ללקוחות המועדון?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(258, 175);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 19;
            label10.Text = "תאריך תחילת המבצע:";
            // 
            // upsalecmb
            // 
            upsalecmb.FormattingEnabled = true;
            upsalecmb.Location = new Point(46, 34);
            upsalecmb.Name = "upsalecmb";
            upsalecmb.Size = new Size(121, 23);
            upsalecmb.TabIndex = 18;
            upsalecmb.SelectedValueChanged += upsalecmb_SelectedValueChanged;
            // 
            // umincntnud
            // 
            umincntnud.Location = new Point(46, 69);
            umincntnud.Name = "umincntnud";
            umincntnud.Size = new Size(120, 23);
            umincntnud.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(306, 108);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 16;
            label11.Text = "מחיר במבצע:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 71);
            label12.Name = "label12";
            label12.Size = new Size(126, 15);
            label12.TabIndex = 15;
            label12.Text = "כמות פריטים מינימלית:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(321, 37);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 14;
            label13.Text = "בחר מבצע:";
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(175, 245);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 23);
            updatebtn.TabIndex = 13;
            updatebtn.Text = "עדכן";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += Updatebtn_Click;
            // 
            // delete
            // 
            delete.Controls.Add(deletebtn);
            delete.Controls.Add(dproductscmb);
            delete.Controls.Add(label14);
            delete.Location = new Point(4, 24);
            delete.Name = "delete";
            delete.Size = new Size(427, 303);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(190, 193);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 21;
            deletebtn.Text = "מחק";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += Deletebtn_Click;
            // 
            // dproductscmb
            // 
            dproductscmb.FormattingEnabled = true;
            dproductscmb.Location = new Point(38, 92);
            dproductscmb.Name = "dproductscmb";
            dproductscmb.Size = new Size(121, 23);
            dproductscmb.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(313, 95);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 19;
            label14.Text = "בחר מבצע:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "מבצעים";
            // 
            // allSales
            // 
            allSales.Controls.Add(allSaleslb);
            allSales.Location = new Point(4, 24);
            allSales.Name = "allSales";
            allSales.Size = new Size(427, 303);
            allSales.TabIndex = 3;
            allSales.Text = "כל המבצעים";
            allSales.UseVisualStyleBackColor = true;
            // 
            // allSaleslb
            // 
            allSaleslb.FormattingEnabled = true;
            allSaleslb.ItemHeight = 15;
            allSaleslb.Location = new Point(7, 13);
            allSaleslb.Name = "allSaleslb";
            allSaleslb.Size = new Size(411, 274);
            allSaleslb.TabIndex = 0;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Sales";
            Text = "Sales";
            tabControl1.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)apricenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)amincntnud).EndInit();
            update.ResumeLayout(false);
            update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upricenud).EndInit();
            ((System.ComponentModel.ISupportInitialize)umincntnud).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            allSales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage add;
        private TabPage update;
        private Label label1;
        private TabPage delete;
        private Button addbtn;
        private NumericUpDown amincntnud;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private NumericUpDown apricenud;
        private CheckBox apreferednud;
        private DateTimePicker aenddate;
        private DateTimePicker abegindate;
        private DateTimePicker uenddate;
        private DateTimePicker ubegindate;
        private Label label8;
        private NumericUpDown upricenud;
        private CheckBox upreferedcb;
        private Label label9;
        private Label label10;
        private ComboBox upsalecmb;
        private NumericUpDown umincntnud;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button updatebtn;
        private Button deletebtn;
        private ComboBox dproductscmb;
        private Label label14;
        private ComboBox aproductscmb;
        private Label label2;
        private TabPage allSales;
        private ListBox allSaleslb;
    }
}