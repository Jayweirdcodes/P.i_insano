namespace piForms2
{
    partial class configurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configurações));
            panel1 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            btnSair_Estoque = new Button();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnSair_Estoque);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Cursor = Cursors.No;
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 780);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 224);
            button4.Name = "button4";
            button4.Size = new Size(197, 66);
            button4.TabIndex = 3;
            button4.Text = "Estoque ";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(202, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(434, 8);
            label1.Name = "label1";
            label1.Size = new Size(248, 73);
            label1.TabIndex = 0;
            label1.Text = "Em falta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 157);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Sem faltas ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 253);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Estoque cheio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 323);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 200);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Caixa;
            pictureBox2.Location = new Point(10, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 40);
            label6.Name = "label6";
            label6.Size = new Size(118, 41);
            label6.TabIndex = 6;
            label6.Text = "STILO";
            // 
            // btnSair_Estoque
            // 
            btnSair_Estoque.BackColor = Color.FromArgb(64, 64, 64);
            btnSair_Estoque.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair_Estoque.FlatStyle = FlatStyle.Popup;
            btnSair_Estoque.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair_Estoque.ForeColor = Color.White;
            btnSair_Estoque.Location = new Point(0, 446);
            btnSair_Estoque.Name = "btnSair_Estoque";
            btnSair_Estoque.Size = new Size(197, 66);
            btnSair_Estoque.TabIndex = 12;
            btnSair_Estoque.Text = "Voltar";
            btnSair_Estoque.UseVisualStyleBackColor = false;
            btnSair_Estoque.Click += btnSair_Estoque_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 462);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 336);
            button3.Name = "button3";
            button3.Size = new Size(197, 66);
            button3.TabIndex = 16;
            button3.Text = "Encomendas";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 348);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // configurações
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1351, 780);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "configurações";
            Text = "configurações";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Button btnSair_Estoque;
        private PictureBox pictureBox5;
        private Button button3;
        private PictureBox pictureBox3;
    }
}