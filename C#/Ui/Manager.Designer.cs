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
            productsbtn.Location = new Point(639, 212);
            productsbtn.Name = "productsbtn";
            productsbtn.Size = new Size(75, 23);
            productsbtn.TabIndex = 0;
            productsbtn.Text = "מוצרים";
            productsbtn.UseVisualStyleBackColor = true;
            productsbtn.Click += productsbtn_Click;
            // 
            // customersbtn
            // 
            customersbtn.Location = new Point(430, 211);
            customersbtn.Name = "customersbtn";
            customersbtn.Size = new Size(75, 23);
            customersbtn.TabIndex = 1;
            customersbtn.Text = "לקוחות";
            customersbtn.UseVisualStyleBackColor = true;
            customersbtn.Click += customersbtn_Click;
            // 
            // sales
            // 
            sales.Location = new Point(193, 212);
            sales.Name = "sales";
            sales.Size = new Size(75, 23);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 576);
            Controls.Add(sales);
            Controls.Add(customersbtn);
            Controls.Add(productsbtn);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button productsbtn;
        private Button customersbtn;
        private Button sales;
    }
}