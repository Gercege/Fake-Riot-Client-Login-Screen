namespace Riot_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Image = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            Image.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Image
            // 
            Image.BackgroundImage = (Image)resources.GetObject("Image.BackgroundImage");
            Image.Controls.Add(button1);
            Image.Controls.Add(panel2);
            Image.Controls.Add(textBox2);
            Image.Controls.Add(textBox1);
            Image.Controls.Add(panel1);
            Image.Dock = DockStyle.Fill;
            Image.Location = new Point(0, 0);
            Image.Name = "Image";
            Image.Size = new Size(1924, 1055);
            Image.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(197, 787);
            button1.Name = "button1";
            button1.Size = new Size(90, 96);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(65, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 35);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(2, 7);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(65, 400);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(365, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(65, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 31);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(65, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 35);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(2, 7);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 3;
            label1.Text = "USERNAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(Image);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Riot Client";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            Image.ResumeLayout(false);
            Image.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Image;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Label label2;
        public TextBox textBox1;
        public TextBox textBox2;
    }
}
