namespace CredPaste
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            UserBox = new Label();
            PWBox = new Label();
            label3 = new Label();
            PWOnlyCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(11, 11);
            button1.Name = "button1";
            button1.Size = new Size(261, 29);
            button1.TabIndex = 0;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 49);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // UserBox
            // 
            UserBox.Location = new Point(94, 49);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(178, 20);
            UserBox.TabIndex = 3;
            UserBox.Text = "?";
            // 
            // PWBox
            // 
            PWBox.Location = new Point(94, 79);
            PWBox.Name = "PWBox";
            PWBox.Size = new Size(178, 20);
            PWBox.TabIndex = 4;
            PWBox.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 129);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 5;
            label3.Text = "To Insert Ctrl + Shift + ";
            label3.Click += label3_Click;
            // 
            // PWOnlyCheckBox
            // 
            PWOnlyCheckBox.AutoSize = true;
            PWOnlyCheckBox.Location = new Point(13, 102);
            PWOnlyCheckBox.Name = "PWOnlyCheckBox";
            PWOnlyCheckBox.Size = new Size(124, 24);
            PWOnlyCheckBox.TabIndex = 6;
            PWOnlyCheckBox.Text = "Password only";
            PWOnlyCheckBox.UseVisualStyleBackColor = true;
            PWOnlyCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 161);
            Controls.Add(PWOnlyCheckBox);
            Controls.Add(label3);
            Controls.Add(PWBox);
            Controls.Add(UserBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CredPaste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label UserBox;
        private Label PWBox;
        private Label label3;
        private CheckBox PWOnlyCheckBox;
    }
}
