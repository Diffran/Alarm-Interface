namespace AlarmaForm
{
    partial class Form2
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
            userControl11 = new UserControl1();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.FromArgb(24, 30, 54);
            userControl11.Location = new Point(3, 2);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(694, 533);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(707, 545);
            Controls.Add(userControl11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control Alarma";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl11;
    }
}