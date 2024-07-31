using SistemaVendas.UI_Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nomeLogin_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
        }
    }
}
