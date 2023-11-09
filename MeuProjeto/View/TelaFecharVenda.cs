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
    public partial class TelaFecharVenda : Form
    {
        PDVTela tela;



        public TelaFecharVenda(PDVTela pDVTela)
        {
            InitializeComponent();

            tela = pDVTela;

        }

        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {
            lbl_totalfinal.Text = "R$" + Convert.ToString(tela.totalfinal) + ",00";
            lbl_data.Text = DateTime.Now.ToString();

            for (int i = 0; i < tela.gdv_tabela.RowCount - 1; i++)
            {

                lbl_todos.Text += "\nProduto: " + tela.gdv_tabela.Rows[i].Cells[0].Value.ToString() + " Quantidade: " + tela.gdv_tabela.Rows[i].Cells[1].Value.ToString() + " Unitário: " + tela.gdv_tabela.Rows[i].Cells[2].Value.ToString();
            }


        }
    }
}

