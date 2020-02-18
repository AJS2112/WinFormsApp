using App.SisUsuariosService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using App.Common.Classes;
using App.Common.Forms;
using App.SisEmpresaService;

namespace AppCaja
{
    public partial class frmSisLogin : MetroFramework.Forms.MetroForm
    {
        SisUsuariosClient srv = new SisUsuariosClient();
        public frmSisLogin()
        {
            InitializeComponent();
        }

        private void sisLoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidarTextos();

            SisUsuarios one = new SisUsuarios();
            try
            {
                one = srv.Login(txtNombre.Text, GetSHA1(txtPassword.Text));
                //Console.WriteLine($"usuario: {one.es_inactivo.ToString()} empresa: {one.empresa_inactiva.ToString()}");

                if (one != null)
                {
                    if (one.es_inactivo == false && one.empresa_inactiva == false)
                    {
                        Globals.logUser = one;
                        SisEmpresaClient srvEmpresa = new SisEmpresaClient();
                        Globals.logEmpresa = srvEmpresa.GetOne(Globals.logUser.id_empresa);
                        frmMain myForm = new frmMain();
                        myForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuario Inactivo");
                        txtNombre.Text = "";
                        txtPassword.Text = "";
                        txtNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Fallo en la autenticación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNombre.Text = "";
                    txtPassword.Text = "";
                    txtNombre.Focus();
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Iniciando el Servicio: " + ex.Message);
                Application.Exit();
            }

        }

        private void ValidarTextos()
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingresa un nombre de usuario");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Ingresa una contraseña");
                txtPassword.Focus();
                return;
            }
            errorProvider1.SetError(txtPassword, "");
        }

        private static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
