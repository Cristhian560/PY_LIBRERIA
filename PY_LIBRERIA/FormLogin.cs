using CLASES.ACCESO_A_DATOS;
using CLASES.ENTIDADES;
using PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach (Credencial c in ADO.ListaCredenciales(ADO.Credenciales()))
            {
                if (c.Usuario==textUsuario.Text && c.Contrasenia==textContraseña.Text)
                {
                    FormPrincipal formPrincipal = new FormPrincipal(c.Nombre);
                    formPrincipal.Show();
                }
            }
        }
    }
}
