namespace MeuProjeto.View
{
    partial class TelaFecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharVenda));
            pictureBox1 = new PictureBox();
            lbl_data = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_totalfinal = new Label();
            label8 = new Label();
            lbl_todos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_data.ForeColor = SystemColors.ButtonFace;
            lbl_data.Location = new Point(227, 97);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(126, 25);
            lbl_data.TabIndex = 1;
            lbl_data.Text = "00/00/0000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(176, 122);
            label2.Name = "label2";
            label2.Size = new Size(222, 40);
            label2.TabIndex = 2;
            label2.Text = "CUPOM FISCAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(293, 164);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 3;
            label3.Text = "CCF: 00007";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(409, 164);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 4;
            label4.Text = "COD: 00007";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(44, 164);
            label5.Name = "label5";
            label5.Size = new Size(243, 25);
            label5.TabIndex = 5;
            label5.Text = "CPNJ: 77.132.874/7777-11";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(134, 409);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 6;
            label6.Text = "TOTAL:";
            // 
            // lbl_totalfinal
            // 
            lbl_totalfinal.AutoSize = true;
            lbl_totalfinal.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_totalfinal.ForeColor = SystemColors.ButtonFace;
            lbl_totalfinal.Location = new Point(352, 409);
            lbl_totalfinal.Name = "lbl_totalfinal";
            lbl_totalfinal.Size = new Size(95, 25);
            lbl_totalfinal.TabIndex = 7;
            lbl_totalfinal.Text = "R$ 00,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(115, 459);
            label8.Name = "label8";
            label8.Size = new Size(345, 40);
            label8.TabIndex = 8;
            label8.Text = "PAGAMENTO RECEBIDO";
            // 
            // lbl_todos
            // 
            lbl_todos.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_todos.ForeColor = SystemColors.ButtonFace;
            lbl_todos.Location = new Point(44, 229);
            lbl_todos.Name = "lbl_todos";
            lbl_todos.Size = new Size(488, 139);
            lbl_todos.TabIndex = 10;
            lbl_todos.Text = "DESCRIÇÃO";
            // 
            // TelaFecharVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(574, 508);
            Controls.Add(lbl_todos);
            Controls.Add(label8);
            Controls.Add(lbl_totalfinal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_data);
            Controls.Add(pictureBox1);
            Name = "TelaFecharVenda";
            Text = "TelaFecharVenda";
            Load += TelaFecharVenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_data;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_totalfinal;
        private Label label8;
        private Label lbl_todos;
    }
}