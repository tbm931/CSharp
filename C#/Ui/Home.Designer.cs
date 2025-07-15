namespace Ui
{
    partial class Home
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
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.Location = new Point(779, 285);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 0;
            button1.Text = "מנהל";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Arial", 14F, FontStyle.Bold);
            button2.Location = new Point(401, 285);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 1;
            button2.Text = "קופאי";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 740);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            this.ClientSize = new System.Drawing.Size(1195, 874);
            string imagePath = Path.Combine(Application.StartupPath, "Images", "pexels-kampratt-3797181.jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Panel overlayPanel = new Panel();
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.BackColor = Color.FromArgb(128, 255, 255, 255); // שקיפות 
            this.Controls.Add(overlayPanel);


        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private Button button2;
        private Panel overlayPanel;
        private Label label1;
        private Label label2;
    }
}