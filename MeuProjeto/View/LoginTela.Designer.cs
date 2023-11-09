namespace MeuProjeto.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            txb_usuario = new Label();
            txb_senha = new Label();
            txbuser = new TextBox();
            txbsenha = new TextBox();
            btn_login = new Button();
            btn_sair = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txb_usuario
            // 
            txb_usuario.AutoSize = true;
            txb_usuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txb_usuario.ForeColor = SystemColors.Control;
            txb_usuario.Location = new Point(570, 136);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(89, 30);
            txb_usuario.TabIndex = 0;
            txb_usuario.Text = "Usuário";
            txb_usuario.Click += txb_usuario_Click;
            // 
            // txb_senha
            // 
            txb_senha.AutoSize = true;
            txb_senha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txb_senha.ForeColor = SystemColors.ButtonFace;
            txb_senha.Location = new Point(570, 201);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(73, 30);
            txb_senha.TabIndex = 1;
            txb_senha.Text = "Senha";
            // 
            // txbuser
            // 
            txbuser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbuser.Location = new Point(505, 169);
            txbuser.Name = "txbuser";
            txbuser.Size = new Size(209, 29);
            txbuser.TabIndex = 2;
            // 
            // txbsenha
            // 
            txbsenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbsenha.Location = new Point(505, 234);
            txbsenha.Name = "txbsenha";
            txbsenha.PasswordChar = '*';
            txbsenha.Size = new Size(209, 29);
            txbsenha.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_login.Location = new Point(547, 280);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(134, 30);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_acessar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_sair.Location = new Point(574, 325);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginTela
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_sair);
            Controls.Add(btn_login);
            Controls.Add(txbsenha);
            Controls.Add(txbuser);
            Controls.Add(txb_senha);
            Controls.Add(txb_usuario);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txb_usuario;
        private Label txb_senha;
        private TextBox txbuser;
        private TextBox txbsenha;
        private Button btn_login;
        private Button btn_sair;
        private PictureBox pictureBox1;
    }
}