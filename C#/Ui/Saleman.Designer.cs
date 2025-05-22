namespace Ui
{
    partial class Saleman
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
            tbc = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            cntnud = new NumericUpDown();
            nametxt = new TextBox();
            add = new Button();
            label4 = new Label();
            cb = new CheckBox();
            panel1 = new Panel();
            sum = new Label();
            choosedlb = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            pricetoone = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            priceTotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            nextbtn = new Button();
            tbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntnud).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)choosedlb).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "הזמנה";
            // 
            // tbc
            // 
            tbc.Controls.Add(tabPage1);
            tbc.Controls.Add(tabPage2);
            tbc.Location = new Point(678, 77);
            tbc.Name = "tbc";
            tbc.RightToLeft = RightToLeft.Yes;
            tbc.SelectedIndex = 0;
            tbc.Size = new Size(423, 309);
            tbc.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(415, 276);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(415, 276);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(67, 325);
            button1.Name = "button1";
            button1.Size = new Size(235, 29);
            button1.TabIndex = 2;
            button1.Text = "לסיום הזמנה ולתשלום סופי";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 243);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "סך הכל:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1020, 41);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "בחר מוצר:";
            // 
            // cntnud
            // 
            cntnud.Location = new Point(520, 185);
            cntnud.Name = "cntnud";
            cntnud.Size = new Size(77, 27);
            cntnud.TabIndex = 7;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(513, 120);
            nametxt.Name = "nametxt";
            nametxt.ReadOnly = true;
            nametxt.Size = new Size(97, 27);
            nametxt.TabIndex = 8;
            // 
            // add
            // 
            add.Location = new Point(514, 234);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 9;
            add.Tag = "";
            add.Text = "להוספה";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 41);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(193, 20);
            label4.TabIndex = 12;
            label4.Text = "האם הלקוח הוא חבר מועדון?";
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Location = new Point(20, 45);
            cb.Name = "cb";
            cb.Size = new Size(18, 17);
            cb.TabIndex = 13;
            cb.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(sum);
            panel1.Controls.Add(choosedlb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cntnud);
            panel1.Controls.Add(tbc);
            panel1.Controls.Add(nametxt);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(add);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 405);
            panel1.TabIndex = 14;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(93, 243);
            sum.Name = "sum";
            sum.Size = new Size(17, 20);
            sum.TabIndex = 13;
            sum.Text = "0";
            // 
            // choosedlb
            // 
            choosedlb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            choosedlb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            choosedlb.Columns.AddRange(new DataGridViewColumn[] { name, pricetoone, count, priceTotal });
            choosedlb.Location = new Point(14, 24);
            choosedlb.Name = "choosedlb";
            choosedlb.RightToLeft = RightToLeft.Yes;
            choosedlb.RowHeadersWidth = 51;
            choosedlb.Size = new Size(426, 188);
            choosedlb.TabIndex = 12;
            choosedlb.CellDoubleClick += Choosedlb_CellDoubleClick;
            // 
            // name
            // 
            name.HeaderText = "שם מוצר";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 95;
            // 
            // pricetoone
            // 
            pricetoone.HeaderText = "מחיר ליחידה";
            pricetoone.MinimumWidth = 6;
            pricetoone.Name = "pricetoone";
            pricetoone.ReadOnly = true;
            pricetoone.Width = 117;
            // 
            // count
            // 
            count.HeaderText = "כמות";
            count.MinimumWidth = 6;
            count.Name = "count";
            count.ReadOnly = true;
            count.Width = 71;
            // 
            // priceTotal
            // 
            priceTotal.HeaderText = "מחיר כולל";
            priceTotal.MinimumWidth = 6;
            priceTotal.Name = "priceTotal";
            priceTotal.ReadOnly = true;
            priceTotal.Width = 102;
            // 
            // panel2
            // 
            panel2.Controls.Add(nextbtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cb);
            panel2.Location = new Point(374, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 147);
            panel2.TabIndex = 15;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(137, 98);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(94, 29);
            nextbtn.TabIndex = 14;
            nextbtn.Text = "אישור";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += Nextbtn_Click;
            // 
            // Saleman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 505);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Saleman";
            Text = "Saleman";
            tbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cntnud).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)choosedlb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tbc;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label2;
        private Label label3;
        private NumericUpDown cntnud;
        private TextBox nametxt;
        private Button add;
        private Label label4;
        private CheckBox cb;
        private Panel panel1;
        private Panel panel2;
        private Button nextbtn;
        private DataGridView choosedlb;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn pricetoone;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn priceTotal;
        private Label sum;
    }
}