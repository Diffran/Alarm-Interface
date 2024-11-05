namespace AlarmaForm
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            btn_visibility = new Button();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label_Alarma_State = new Label();
            label_Alarma = new Label();
            panel2 = new Panel();
            btn_O = new Button();
            btn_0 = new Button();
            btn_X = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 497);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 30, 54);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(btn_visibility);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 82);
            panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 30, 54);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("DejaVu Sans Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 126, 249);
            textBox1.Location = new Point(126, 29);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "----";
            textBox1.Size = new Size(66, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btn_visibility
            // 
            btn_visibility.BackColor = Color.FromArgb(24, 30, 54);
            btn_visibility.FlatAppearance.BorderSize = 0;
            btn_visibility.FlatStyle = FlatStyle.Flat;
            btn_visibility.ForeColor = Color.FromArgb(0, 126, 249);
            btn_visibility.Image = Properties.Resources.visibilidad_Blau;
            btn_visibility.Location = new Point(197, 20);
            btn_visibility.Name = "btn_visibility";
            btn_visibility.Size = new Size(45, 40);
            btn_visibility.TabIndex = 1;
            btn_visibility.UseVisualStyleBackColor = false;
            btn_visibility.Click += btn_visibility_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DejaVu Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(43, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Codi: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label_Alarma_State);
            panel3.Controls.Add(label_Alarma);
            panel3.Location = new Point(341, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 453);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.candado_abierto;
            pictureBox2.InitialImage = Properties.Resources.candado_abierto;
            pictureBox2.Location = new Point(38, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 209);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label_Alarma_State
            // 
            label_Alarma_State.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Alarma_State.ForeColor = Color.FromArgb(0, 126, 249);
            label_Alarma_State.Location = new Point(3, 73);
            label_Alarma_State.Name = "label_Alarma_State";
            label_Alarma_State.Size = new Size(278, 32);
            label_Alarma_State.TabIndex = 1;
            label_Alarma_State.Text = "Desconnectada";
            label_Alarma_State.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Alarma
            // 
            label_Alarma.AutoSize = true;
            label_Alarma.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Alarma.ForeColor = Color.FromArgb(158, 161, 176);
            label_Alarma.Location = new Point(83, 30);
            label_Alarma.Name = "label_Alarma";
            label_Alarma.Size = new Size(110, 32);
            label_Alarma.TabIndex = 0;
            label_Alarma.Text = "Alarma";
            label_Alarma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(btn_O);
            panel2.Controls.Add(btn_0);
            panel2.Controls.Add(btn_X);
            panel2.Controls.Add(btn_9);
            panel2.Controls.Add(btn_8);
            panel2.Controls.Add(btn_7);
            panel2.Controls.Add(btn_6);
            panel2.Controls.Add(btn_5);
            panel2.Controls.Add(btn_4);
            panel2.Controls.Add(btn_3);
            panel2.Controls.Add(btn_2);
            panel2.Controls.Add(btn_1);
            panel2.Location = new Point(20, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 365);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn_O
            // 
            btn_O.FlatStyle = FlatStyle.Flat;
            btn_O.ForeColor = Color.FromArgb(0, 126, 249);
            btn_O.Image = Properties.Resources.checkmark;
            btn_O.Location = new Point(196, 274);
            btn_O.Name = "btn_O";
            btn_O.Size = new Size(66, 66);
            btn_O.TabIndex = 21;
            btn_O.UseVisualStyleBackColor = true;
            btn_O.Click += btn_O_Click;
            // 
            // btn_0
            // 
            btn_0.FlatStyle = FlatStyle.Flat;
            btn_0.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_0.ForeColor = Color.FromArgb(0, 126, 249);
            btn_0.Location = new Point(111, 274);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(66, 66);
            btn_0.TabIndex = 20;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += button_Number_Click;
            // 
            // btn_X
            // 
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.ForeColor = Color.FromArgb(0, 126, 249);
            btn_X.Image = Properties.Resources.close2;
            btn_X.Location = new Point(27, 274);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(66, 66);
            btn_X.TabIndex = 19;
            btn_X.UseVisualStyleBackColor = true;
            btn_X.Click += btn_X_Click;
            // 
            // btn_9
            // 
            btn_9.FlatStyle = FlatStyle.Flat;
            btn_9.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_9.ForeColor = Color.FromArgb(0, 126, 249);
            btn_9.Location = new Point(196, 196);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(66, 66);
            btn_9.TabIndex = 18;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += button_Number_Click;
            // 
            // btn_8
            // 
            btn_8.FlatStyle = FlatStyle.Flat;
            btn_8.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_8.ForeColor = Color.FromArgb(0, 126, 249);
            btn_8.Location = new Point(111, 196);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(66, 66);
            btn_8.TabIndex = 17;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += button_Number_Click;
            // 
            // btn_7
            // 
            btn_7.FlatStyle = FlatStyle.Flat;
            btn_7.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_7.ForeColor = Color.FromArgb(0, 126, 249);
            btn_7.Location = new Point(27, 196);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(66, 66);
            btn_7.TabIndex = 16;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += button_Number_Click;
            // 
            // btn_6
            // 
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_6.ForeColor = Color.FromArgb(0, 126, 249);
            btn_6.Location = new Point(196, 115);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(66, 66);
            btn_6.TabIndex = 15;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += button_Number_Click;
            // 
            // btn_5
            // 
            btn_5.FlatStyle = FlatStyle.Flat;
            btn_5.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_5.ForeColor = Color.FromArgb(0, 126, 249);
            btn_5.Location = new Point(111, 115);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(66, 66);
            btn_5.TabIndex = 14;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += button_Number_Click;
            // 
            // btn_4
            // 
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_4.ForeColor = Color.FromArgb(0, 126, 249);
            btn_4.Location = new Point(27, 115);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(66, 66);
            btn_4.TabIndex = 13;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += button_Number_Click;
            // 
            // btn_3
            // 
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_3.ForeColor = Color.FromArgb(0, 126, 249);
            btn_3.Location = new Point(196, 31);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(66, 66);
            btn_3.TabIndex = 12;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += button_Number_Click;
            // 
            // btn_2
            // 
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_2.ForeColor = Color.FromArgb(0, 126, 249);
            btn_2.Location = new Point(111, 31);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(66, 66);
            btn_2.TabIndex = 11;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += button_Number_Click;
            // 
            // btn_1
            // 
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Font = new Font("DejaVu Sans Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_1.ForeColor = Color.FromArgb(0, 126, 249);
            btn_1.Location = new Point(27, 31);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(66, 66);
            btn_1.TabIndex = 10;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += button_Number_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(694, 533);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button btn_visibility;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_O;
        private Button btn_0;
        private Button btn_X;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label_Alarma;
        private Label label_Alarma_State;
        private PictureBox pictureBox2;
    }
}
