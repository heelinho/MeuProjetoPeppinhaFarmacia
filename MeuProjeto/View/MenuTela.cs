using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuProjeto.View
{
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDVTela pDVTela = new PDVTela();
            pDVTela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
