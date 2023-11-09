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
    public partial class PDVTela : Form
    {
        public int totalfinal = 0;


        public PDVTela()
        {
            InitializeComponent();
        }

        private void btn_Neosaldina_Click(object sender, EventArgs e)
        {
            string registroNeosaldina = "10";
            txb_codigo.Text = registroNeosaldina;
        }

        private void btn_Engov_Click(object sender, EventArgs e)
        {
            string registroEngov = "11";
            txb_codigo.Text = registroEngov;
        }

        private void btn_Novalgina_Click(object sender, EventArgs e)
        {
            string registroNovalgina = "12";
            txb_codigo.Text = registroNovalgina;
        }

        private void btn_Doril_Click(object sender, EventArgs e)
        {
            string registroDoril = "13";
            txb_codigo.Text = registroDoril;
        }

        private void btn_Dipirona_Click(object sender, EventArgs e)
        {
            string registroDipirona = "14";
            txb_codigo.Text = registroDipirona;
        }

        private void btn_Rivotril_Click(object sender, EventArgs e)
        {
            string registroRivotril = "15";
            txb_codigo.Text = registroRivotril;
        }

        private void btn_Ducolax_Click(object sender, EventArgs e)
        {
            string registroDucolax = "16";
            txb_codigo.Text = registroDucolax;
        }

        private void btn_Minilax_Click(object sender, EventArgs e)
        {
            string registroMinilax = "17";
            txb_codigo.Text = registroMinilax;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txb_codigo.Text);
            int qtd = (int)txb_qtde.Value;

            string[] itens = { "Neosaldina", "Engov", "Novalgina ", "Doril", "Dipirona", "Rivotril", "Ducolax", "Minilax" };
            int[] valor = { 24, 12, 37, 9, 5, 27, 17, 48 };
            int total;

            if (codigo == 10)
            {
                total = qtd * valor[0];
                gdv_tabela.Rows.Add(itens[0], txb_qtde.Value, valor[0], total);
            }
            else if (codigo == 11)
            {
                total = qtd * valor[1];
                gdv_tabela.Rows.Add(itens[1], txb_qtde.Value, valor[1], total);
            }
            else if (codigo == 12)
            {
                total = qtd * valor[2];
                gdv_tabela.Rows.Add(itens[2], txb_qtde.Value, valor[2], total);
            }
            else if (codigo == 13)
            {
                total = qtd * valor[3];
                gdv_tabela.Rows.Add(itens[3], txb_qtde.Value, valor[3], total);
            }
            else if (codigo == 14)
            {
                total = qtd * valor[4];
                gdv_tabela.Rows.Add(itens[4], txb_qtde.Value, valor[4], total);
            }
            else if (codigo == 15)
            {
                total = qtd * valor[5];
                gdv_tabela.Rows.Add(itens[5], txb_qtde.Value, valor[5], total);
            }
            else if (codigo == 16)
            {
                total = qtd * valor[6];
                gdv_tabela.Rows.Add(itens[6], txb_qtde.Value, valor[6], total);
            }
            else if (codigo == 17)
            {
                total = qtd * valor[7];
                gdv_tabela.Rows.Add(itens[7], txb_qtde.Value, valor[7], total);
            }
            else
            {
                MessageBox.Show("Código inválido");
                return;
            }

            totalfinal += total;
            lbl_ValorTotal.Text = "R$" + totalfinal.ToString() + ",00";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_ValorTotal.Text = string.Empty;
            txb_codigo.Text = string.Empty;
            txb_qtde.Value = 0;
            gdv_tabela.Rows.Clear();
        }

        private void btn_rf_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFecharVenda telaFecharVenda = new TelaFecharVenda(this);
            telaFecharVenda.FormClosed += (s, args) => this.Close();
            telaFecharVenda.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}

