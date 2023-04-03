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
            BarraLateral = new Panel();
            PanelControlador = new Panel();
            btnCerrar = new PictureBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(56, 9, 120);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.FlowDirection = FlowDirection.RightToLeft;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 35);
            BarraTitulo.TabIndex = 0;
            // 
            // BarraLateral
            // 
            BarraLateral.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BarraLateral.BackColor = Color.FromArgb(26, 32, 50);
            BarraLateral.Location = new Point(0, 35);
            BarraLateral.Name = "BarraLateral";
            BarraLateral.Size = new Size(250, 715);
            BarraLateral.TabIndex = 1;
            // 
            // PanelControlador
            // 
            PanelControlador.Location = new Point(250, 35);
            PanelControlador.Name = "PanelControlador";
            PanelControlador.Size = new Size(1050, 715);
            PanelControlador.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1267, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel BarraTitulo;
        private PictureBox btnCerrar;
        private Panel BarraLateral;
        private Panel PanelControlador;
    }
}