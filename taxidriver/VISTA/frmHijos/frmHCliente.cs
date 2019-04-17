using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxidriver.VISTA.frmHijos
{
    public partial class frmHCliente : frmPadres.frmPGestionar
    {
        public frmHCliente()
        {
            InitializeComponent();
        }

        private void btnResgitrarServicio_Click(object sender, EventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();

            VISTA.frmHijos.frmHRegistrarServicio frmReg = new VISTA.frmHijos.frmHRegistrarServicio();
            frmReg.BackColor = Color.Cornsilk;
            frmReg.ShowDialog();
        }
    }
}
