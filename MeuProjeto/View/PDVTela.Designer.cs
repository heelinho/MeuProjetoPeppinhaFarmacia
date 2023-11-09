namespace MeuProjeto.View
{
    partial class PDVTela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            lbl_medicamentos = new Label();
            btn_Neosaldina = new Button();
            btn_Engov = new Button();
            btn_Novalgina = new Button();
            btn_Doril = new Button();
            btn_Dipirona = new Button();
            btn_Rivotril = new Button();
            btn_Ducolax = new Button();
            btn_Minilax = new Button();
            label1 = new Label();
            label2 = new Label();
            txb_codigo = new TextBox();
            txb_qtde = new NumericUpDown();
            btn_add = new Button();
            gdv_tabela = new DataGridView();
            Produtos = new DataGridViewTextBoxColumn();
            Qtde = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_clear = new Button();
            label3 = new Label();
            btn_cancelar = new Button();
            btn_rf = new Button();
            lbl_ValorTotal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txb_qtde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdv_tabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_medicamentos
            // 
            lbl_medicamentos.AutoSize = true;
            lbl_medicamentos.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_medicamentos.ForeColor = SystemColors.ButtonFace;
            lbl_medicamentos.Location = new Point(12, 83);
            lbl_medicamentos.Name = "lbl_medicamentos";
            lbl_medicamentos.Size = new Size(148, 25);
            lbl_medicamentos.TabIndex = 0;
            lbl_medicamentos.Text = "Medicamentos";
            // 
            // btn_Neosaldina
            // 
            btn_Neosaldina.Location = new Point(33, 164);
            btn_Neosaldina.Name = "btn_Neosaldina";
            btn_Neosaldina.Size = new Size(75, 75);
            btn_Neosaldina.TabIndex = 1;
            btn_Neosaldina.Text = "Neosaldina ";
            btn_Neosaldina.UseVisualStyleBackColor = true;
            btn_Neosaldina.Click += btn_Neosaldina_Click;
            // 
            // btn_Engov
            // 
            btn_Engov.Location = new Point(129, 164);
            btn_Engov.Name = "btn_Engov";
            btn_Engov.Size = new Size(75, 75);
            btn_Engov.TabIndex = 2;
            btn_Engov.Text = "Engov";
            btn_Engov.UseVisualStyleBackColor = true;
            btn_Engov.Click += btn_Engov_Click;
            // 
            // btn_Novalgina
            // 
            btn_Novalgina.Location = new Point(229, 164);
            btn_Novalgina.Name = "btn_Novalgina";
            btn_Novalgina.Size = new Size(75, 75);
            btn_Novalgina.TabIndex = 3;
            btn_Novalgina.Text = "Novalgina ";
            btn_Novalgina.UseVisualStyleBackColor = true;
            btn_Novalgina.Click += btn_Novalgina_Click;
            // 
            // btn_Doril
            // 
            btn_Doril.Location = new Point(329, 164);
            btn_Doril.Name = "btn_Doril";
            btn_Doril.Size = new Size(75, 75);
            btn_Doril.TabIndex = 4;
            btn_Doril.Text = "Doril ";
            btn_Doril.UseVisualStyleBackColor = true;
            btn_Doril.Click += btn_Doril_Click;
            // 
            // btn_Dipirona
            // 
            btn_Dipirona.Location = new Point(33, 300);
            btn_Dipirona.Name = "btn_Dipirona";
            btn_Dipirona.Size = new Size(75, 75);
            btn_Dipirona.TabIndex = 5;
            btn_Dipirona.Text = "Dipirona";
            btn_Dipirona.UseVisualStyleBackColor = true;
            btn_Dipirona.Click += btn_Dipirona_Click;
            // 
            // btn_Rivotril
            // 
            btn_Rivotril.Location = new Point(129, 300);
            btn_Rivotril.Name = "btn_Rivotril";
            btn_Rivotril.Size = new Size(75, 75);
            btn_Rivotril.TabIndex = 6;
            btn_Rivotril.Text = "Rivotril ";
            btn_Rivotril.UseVisualStyleBackColor = true;
            btn_Rivotril.Click += btn_Rivotril_Click;
            // 
            // btn_Ducolax
            // 
            btn_Ducolax.Location = new Point(229, 300);
            btn_Ducolax.Name = "btn_Ducolax";
            btn_Ducolax.Size = new Size(75, 75);
            btn_Ducolax.TabIndex = 7;
            btn_Ducolax.Text = "Ducolax";
            btn_Ducolax.UseVisualStyleBackColor = true;
            btn_Ducolax.Click += btn_Ducolax_Click;
            // 
            // btn_Minilax
            // 
            btn_Minilax.Location = new Point(329, 300);
            btn_Minilax.Name = "btn_Minilax";
            btn_Minilax.Size = new Size(75, 75);
            btn_Minilax.TabIndex = 8;
            btn_Minilax.Text = "Minilax";
            btn_Minilax.UseVisualStyleBackColor = true;
            btn_Minilax.Click += btn_Minilax_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(571, 167);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 9;
            label1.Text = "Cod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(748, 164);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 10;
            label2.Text = "Qtde";
            // 
            // txb_codigo
            // 
            txb_codigo.Location = new Point(615, 164);
            txb_codigo.Name = "txb_codigo";
            txb_codigo.Size = new Size(100, 23);
            txb_codigo.TabIndex = 11;
            // 
            // txb_qtde
            // 
            txb_qtde.Location = new Point(816, 165);
            txb_qtde.Name = "txb_qtde";
            txb_qtde.Size = new Size(32, 23);
            txb_qtde.TabIndex = 12;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_add.Location = new Point(900, 164);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // gdv_tabela
            // 
            gdv_tabela.BackgroundColor = SystemColors.ButtonFace;
            gdv_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdv_tabela.Columns.AddRange(new DataGridViewColumn[] { Produtos, Qtde, Unitário, Total });
            gdv_tabela.Location = new Point(571, 211);
            gdv_tabela.Name = "gdv_tabela";
            gdv_tabela.RowHeadersVisible = false;
            gdv_tabela.RowTemplate.Height = 25;
            gdv_tabela.Size = new Size(404, 164);
            gdv_tabela.TabIndex = 14;
            // 
            // Produtos
            // 
            Produtos.HeaderText = "Produtos";
            Produtos.Name = "Produtos";
            // 
            // Qtde
            // 
            Qtde.HeaderText = "Qtde";
            Qtde.Name = "Qtde";
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário";
            Unitário.Name = "Unitário";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_clear.Location = new Point(571, 381);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 34);
            btn_clear.TabIndex = 15;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(784, 386);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 16;
            label3.Text = "Valor Total";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(571, 426);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 34);
            btn_cancelar.TabIndex = 18;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_rf
            // 
            btn_rf.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_rf.Location = new Point(842, 426);
            btn_rf.Name = "btn_rf";
            btn_rf.Size = new Size(133, 34);
            btn_rf.TabIndex = 19;
            btn_rf.Text = "Receber e Finalizar";
            btn_rf.UseVisualStyleBackColor = true;
            btn_rf.Click += btn_rf_Click;
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.BackColor = SystemColors.ControlDark;
            lbl_ValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_ValorTotal.ForeColor = SystemColors.ButtonHighlight;
            lbl_ValorTotal.Location = new Point(882, 388);
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            lbl_ValorTotal.Size = new Size(93, 23);
            lbl_ValorTotal.TabIndex = 20;
            lbl_ValorTotal.Text = "R$ 0,0";
            lbl_ValorTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1023, 472);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(btn_rf);
            Controls.Add(btn_cancelar);
            Controls.Add(label3);
            Controls.Add(btn_clear);
            Controls.Add(gdv_tabela);
            Controls.Add(btn_add);
            Controls.Add(txb_qtde);
            Controls.Add(txb_codigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Minilax);
            Controls.Add(btn_Ducolax);
            Controls.Add(btn_Rivotril);
            Controls.Add(btn_Dipirona);
            Controls.Add(btn_Doril);
            Controls.Add(btn_Novalgina);
            Controls.Add(btn_Engov);
            Controls.Add(btn_Neosaldina);
            Controls.Add(lbl_medicamentos);
            Name = "PDVTela";
            Text = "PDVTela";
            ((System.ComponentModel.ISupportInitialize)txb_qtde).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdv_tabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_medicamentos;
        private Button btn_Neosaldina;
        private Button btn_Engov;
        private Button btn_Novalgina;
        private Button btn_Doril;
        private Button btn_Dipirona;
        private Button btn_Rivotril;
        private Button btn_Ducolax;
        private Button btn_Minilax;
        private Label label1;
        private Label label2;
        private TextBox txb_codigo;
        private NumericUpDown txb_qtde;
        private Button btn_add;
        private DataGridViewTextBoxColumn Produtos;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Button btn_clear;
        private Label label3;
        private Button btn_cancelar;
        private Button btn_rf;
        private Label lbl_ValorTotal;
        private PictureBox pictureBox1;
        public DataGridView gdv_tabela;
    }
}