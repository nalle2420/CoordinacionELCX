namespace Coordinacion
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
            BarraTitulo = new FlowLayoutPanel();
            btnCerrar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            BarraLateral = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            PanelControlador = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            BarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(56, 9, 120);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.FlowDirection = FlowDirection.RightToLeft;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 35);
            BarraTitulo.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1267, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1231, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 30);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1195, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // BarraLateral
            // 
            BarraLateral.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BarraLateral.BackColor = Color.FromArgb(26, 32, 50);
            BarraLateral.Controls.Add(panel4);
            BarraLateral.Controls.Add(panel3);
            BarraLateral.Controls.Add(button4);
            BarraLateral.Controls.Add(button3);
            BarraLateral.Controls.Add(panel2);
            BarraLateral.Controls.Add(button2);
            BarraLateral.Controls.Add(panel1);
            BarraLateral.Controls.Add(button1);
            BarraLateral.Controls.Add(pictureBox1);
            BarraLateral.Location = new Point(0, 35);
            BarraLateral.Name = "BarraLateral";
            BarraLateral.Size = new Size(250, 715);
            BarraLateral.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 9, 120);
            panel1.Location = new Point(3, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 38);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 9, 120);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 125);
            button1.Name = "button1";
            button1.Size = new Size(238, 38);
            button1.TabIndex = 1;
            button1.Text = "Coordinación";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelControlador
            // 
            PanelControlador.Location = new Point(250, 35);
            PanelControlador.Name = "PanelControlador";
            PanelControlador.Size = new Size(1050, 715);
            PanelControlador.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 32, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 9, 120);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 185);
            button2.Name = "button2";
            button2.Size = new Size(238, 38);
            button2.TabIndex = 2;
            button2.Text = "Inventario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(56, 9, 120);
            panel2.Location = new Point(0, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 38);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(56, 9, 120);
            panel3.Location = new Point(0, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 38);
            panel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(26, 32, 50);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 9, 120);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 248);
            button3.Name = "button3";
            button3.Size = new Size(238, 38);
            button3.TabIndex = 4;
            button3.Text = "Usuarios";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(56, 9, 120);
            panel4.Location = new Point(0, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 38);
            panel4.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(26, 32, 50);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 9, 120);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 308);
            button4.Name = "button4";
            button4.Size = new Size(238, 38);
            button4.TabIndex = 4;
            button4.Text = "Contratos";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 750);
            Controls.Add(PanelControlador);
            Controls.Add(BarraLateral);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            BarraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel BarraTitulo;
        private PictureBox btnCerrar;
        private Panel BarraLateral;
        private Panel PanelControlador;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Panel panel4;
        private Panel panel3;
        private Button button4;
        private Button button3;
    }
}