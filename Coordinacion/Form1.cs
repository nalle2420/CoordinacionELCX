using System.Runtime.InteropServices;
namespace Coordinacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(typeof(DatosGenerales));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form formularioHijoActual;

        public void AbrirFormularioHijo(Type tipoFormulario)
        {
            // Verificar si ya hay un formulario hijo abierto
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }

            // Crear y abrir el nuevo formulario hijo en el contenedor
            Form nuevoFormularioHijo = (Form)Activator.CreateInstance(tipoFormulario);
            nuevoFormularioHijo.TopLevel = false;
            nuevoFormularioHijo.FormBorderStyle = FormBorderStyle.None;
            nuevoFormularioHijo.Dock = DockStyle.Fill;
            PanelControlador.Controls.Add(nuevoFormularioHijo);
            PanelControlador.Tag = nuevoFormularioHijo;
            nuevoFormularioHijo.BringToFront();
            nuevoFormularioHijo.Show();

            // Actualizar el formulario hijo actual
            formularioHijoActual = nuevoFormularioHijo;
        }


        /* public void AbrirFormHijo(object formHijo)
         {
             if (this.PanelControlador.Controls.Count > 0)
             {
                 this.PanelControlador.Controls.RemoveAt(0);
             }
             Form fh = formHijo as Form;
             fh.TopLevel = false;
             fh.Dock = DockStyle.Fill;
             this.PanelControlador.Controls.Add(fh);
             this.PanelControlador.Tag = fh;
             fh.Show();
         }*/

        private void btnCoordinacion_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(typeof(Coordinación));
        }
    }
}