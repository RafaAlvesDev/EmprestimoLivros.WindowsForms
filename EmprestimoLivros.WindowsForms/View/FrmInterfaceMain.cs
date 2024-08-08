using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmInterfaceMain : Form
    {
        public FrmInterfaceMain()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmClienteMain frmClienteMain = new FrmClienteMain())
            {
                frmClienteMain.ShowDialog();
            }
        }
    }
}
