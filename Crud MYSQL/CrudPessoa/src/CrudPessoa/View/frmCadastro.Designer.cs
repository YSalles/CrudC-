namespace CrudPessoa.View
{
    partial class frmCadastro
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
            panel1 = new Panel();
            edtCPF = new TextBox();
            edtEmail = new TextBox();
            edtNome = new TextBox();
            lblCpf = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(edtCPF);
            panel1.Controls.Add(edtEmail);
            panel1.Controls.Add(edtNome);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 327);
            panel1.TabIndex = 20;
            // 
            // edtCPF
            // 
            edtCPF.Font = new Font("Segoe UI", 11.25F);
            edtCPF.Location = new Point(33, 208);
            edtCPF.Name = "edtCPF";
            edtCPF.Size = new Size(316, 27);
            edtCPF.TabIndex = 19;
            // 
            // edtEmail
            // 
            edtEmail.Font = new Font("Segoe UI", 11.25F);
            edtEmail.Location = new Point(33, 146);
            edtEmail.Name = "edtEmail";
            edtEmail.Size = new Size(316, 27);
            edtEmail.TabIndex = 18;
            // 
            // edtNome
            // 
            edtNome.Font = new Font("Segoe UI", 11.25F);
            edtNome.Location = new Point(33, 81);
            edtNome.Name = "edtNome";
            edtNome.Size = new Size(316, 27);
            edtNome.TabIndex = 17;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblCpf.Location = new Point(33, 180);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(45, 25);
            lblCpf.TabIndex = 16;
            lblCpf.Text = "CPF";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblEmail.Location = new Point(35, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 25);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(33, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(206, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 50);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btndeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(45, 261);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(130, 50);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(405, 337);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCadastro";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox edtCPF;
        private TextBox edtEmail;
        private TextBox edtNome;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblNome;
    }
}