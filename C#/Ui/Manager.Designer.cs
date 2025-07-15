namespace Ui
{
    partial class Manager
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
            productsbtn = new Button();
            customersbtn = new Button();
            sales = new Button();
            SuspendLayout();
            // 
            // productsbtn
            // 
            productsbtn.Location = new Point(730, 283);
            productsbtn.Margin = new Padding(3, 4, 3, 4);
            productsbtn.Name = "productsbtn";
            productsbtn.Size = new Size(120, 50);
            productsbtn.BackColor = Color.LightBlue;
            productsbtn.Font = new Font("Arial", 10, FontStyle.Bold); productsbtn.TabIndex = 0;
            productsbtn.Text = "מוצרים";
            productsbtn.UseVisualStyleBackColor = true;
            productsbtn.Click += productsbtn_Click;
            // 
            // customersbtn
            // 
            customersbtn.Location = new Point(491, 281);
            customersbtn.Margin = new Padding(3, 4, 3, 4);
            customersbtn.Name = "customersbtn";
            customersbtn.Size = new Size(120, 50);
            customersbtn.BackColor = Color.LightBlue;
            customersbtn.Font = new Font("Arial", 10, FontStyle.Bold); productsbtn.TabIndex = 0; customersbtn.TabIndex = 1;
            customersbtn.Text = "לקוחות";
            customersbtn.UseVisualStyleBackColor = true;
            customersbtn.Click += customersbtn_Click;
            // 
            // salesbtn
            // 
            sales.Location = new Point(221, 283);
            sales.Margin = new Padding(3, 4, 3, 4);
            sales.Name = "sales";
            sales.Size = new Size(120, 50);
            sales.BackColor = Color.LightBlue;
            sales.Font = new Font("Arial", 10, FontStyle.Bold); sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 768);
            Controls.Add(sales);
            Controls.Add(customersbtn);
            Controls.Add(productsbtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button productsbtn;
        private Button customersbtn;
        private Button sales;
    }
}