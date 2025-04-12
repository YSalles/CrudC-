namespace CrudPessoa
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgpessoa = new DataGridView();
            btnnovo = new Button();
            btneditar = new Button();
            btndeletar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgpessoa).BeginInit();
            SuspendLayout();
            // 
            // dgpessoa
            // 
            dgpessoa.BackgroundColor = SystemColors.ActiveBorder;
            dgpessoa.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgpessoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgpessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgpessoa.Dock = DockStyle.Right;
            dgpessoa.GridColor = SystemColors.InactiveCaptionText;
            dgpessoa.Location = new Point(193, 5);
            dgpessoa.Name = "dgpessoa";
            dgpessoa.RowHeadersWidth = 51;
            dgpessoa.Size = new Size(498, 340);
            dgpessoa.TabIndex = 0;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.Lime;
            btnnovo.Cursor = Cursors.Hand;
            btnnovo.Dock = DockStyle.Top;
            btnnovo.Location = new Point(5, 5);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(188, 70);
            btnnovo.TabIndex = 9;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click_1;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Yellow;
            btneditar.Cursor = Cursors.Hand;
            btneditar.Dock = DockStyle.Top;
            btneditar.Location = new Point(5, 75);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(188, 70);
            btneditar.TabIndex = 10;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btndeletar
            // 
            btndeletar.BackColor = Color.FromArgb(255, 128, 0);
            btndeletar.Cursor = Cursors.Hand;
            btndeletar.Dock = DockStyle.Top;
            btndeletar.Location = new Point(5, 145);
            btndeletar.Name = "btndeletar";
            btndeletar.Size = new Size(188, 70);
            btndeletar.TabIndex = 11;
            btndeletar.Text = "Deletar";
            btndeletar.UseVisualStyleBackColor = false;
            btndeletar.Click += btndeletar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.OrangeRed;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Dock = DockStyle.Bottom;
            btnFechar.Location = new Point(5, 295);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(188, 50);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(696, 350);
            Controls.Add(btnFechar);
            Controls.Add(btndeletar);
            Controls.Add(btneditar);
            Controls.Add(btnnovo);
            Controls.Add(dgpessoa);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmPrincipal";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pessoa";
            Shown += frmPrincipal_Shown;
            ((System.ComponentModel.ISupportInitialize)dgpessoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgpessoa;
        private Button btnnovo;
        private Button btneditar;
        private Button btndeletar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnFechar;
    }
}
