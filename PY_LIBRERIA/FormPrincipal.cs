using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES.ACCESO_A_DATOS;
using System.Runtime.InteropServices;

namespace PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(string nombre)
        {
            InitializeComponent();
            PersonalizarDiseño();
            txtUsuario.Text = nombre;
        }
        //to free move the form in the screen
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lParam);

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
            ADO.ListaProductos(ADO.Productos());
        }
        private void PersonalizarDiseño()
        {
            panelProducto.Visible = false;
        }
        private void EsconderSubmenu()
        {
            if (panelProducto.Visible == true)
                panelProducto.Visible = false;
            //if (panel3.Visible == true)
            //    panel3.Visible = false;
            //if (panel4.Visible == true)
            //    panel4.Visible = false;
            //if (panel5.Visible == true)
            //    panel5.Visible = false;
        }
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProducto);
        }
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new ();
            AbrirForm(formAlta);
            pictureLogo.Visible = false;
        }
        private void AbrirForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.Show();
        }

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            ADO.Productos();
        }
    }
}
