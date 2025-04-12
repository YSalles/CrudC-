using CrudPessoa.Controllers;
using CrudPessoa.Models;
using CrudPessoa.View;

namespace CrudPessoa
{
    public partial class frmPrincipal : Form
    {
        // atributo privado para pegar a instancia da classe controller
        private PessoaController _pessoaController;

        public frmPrincipal()
        {
            InitializeComponent();
            _pessoaController = new PessoaController();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid() // M�todo para atualizar o DataGridView
        {
            // Atribui a lista de pessoas ao DataGridView
            dgpessoa.DataSource = _pessoaController.GetPessoas();

            // Definir o modo de sele��o para selecionar a linha inteira
            dgpessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configura o estilo da c�lula selecionada
            dgpessoa.DefaultCellStyle.SelectionBackColor = Color.LightBlue;         // Cor de fundo da c�lula selecionada
            dgpessoa.DefaultCellStyle.SelectionForeColor = Color.Black;             // Cor do texto da c�lula selecionada

            // Desabilita a sele��o das colunas (deixa apenas a linha selecionada)
            dgpessoa.AllowUserToAddRows = false; // Impede a sele��o de colunas ao adicionar uma nova linha
            dgpessoa.ColumnHeadersVisible = true;  // Garantir que o cabe�alho da coluna esteja vis�vel

            // Oculta a primeira coluna do seletor de linha
            dgpessoa.RowHeadersVisible = false;

            // Desabilita a edi��o no DataGridView
            dgpessoa.ReadOnly = true;

            // Verifica se h� colunas no DataGridView antes de personalizar
            if (dgpessoa.Columns.Count > 0)
            {
                dgpessoa.Columns["Id"].HeaderText = "C�digo";
                dgpessoa.Columns["Nome"].HeaderText = "Nome";
                dgpessoa.Columns["Cpf"].HeaderText = "CPF";
                dgpessoa.Columns["Email"].HeaderText = "E-mail";

                // Ajusta o tamanho autom�tico das colunas
                dgpessoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Define a cor de fundo e texto das c�lulas
                dgpessoa.DefaultCellStyle.BackColor = Color.LightGray; ;
                dgpessoa.DefaultCellStyle.ForeColor = Color.Black;

                // Define alinhamento centralizado para a coluna 'C�digo'
                dgpessoa.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgpessoa.Columns["Id"].Width = 60;

                // Personaliza o cabe�alho
                dgpessoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dgpessoa.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dgpessoa.EnableHeadersVisualStyles = false;
            }
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            // Cria uma nova inst�ncia do formul�rio de cadastro
            frmCadastro formulario_Cadastro = new frmCadastro();

            // Exibe o formul�rio de cadastro como um modal
            formulario_Cadastro.ShowDialog();

            // Ap�s o formul�rio de cadastro ser fechado, atualiza o grid com os dados mais recentes
            AtualizaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fechar a aplica��o
            this.Close();

            // Encerra a aplica��o
            Application.Exit();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            // Verifica se h� alguma linha selecionada no DataGridView
            if (dgpessoa.SelectedRows.Count > 0)
            {
                // Obt�m o ID da pessoa selecionada (considerando que a coluna "Id" est� na primeira posi��o)
                int idSelecionado = Convert.ToInt32(dgpessoa.SelectedRows[0].Cells["Id"].Value);

                // Pergunta ao usu�rio se tem certeza que deseja excluir
                var confirmacao = MessageBox.Show("Voc� tem certeza que deseja excluir esta pessoa?", "Confirmar Exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    // Chama o reposit�rio para deletar a pessoa
                    bool sucesso = _pessoaController.DeletarPessoa(idSelecionado);

                    if (sucesso)
                    {
                        MessageBox.Show("Pessoa exclu�da com sucesso.");
                        AtualizaGrid(); // Atualiza o grid ap�s a exclus�o
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir a pessoa.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para excluir.");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Verifica se h� linhas selecionadas na DataGridView
            if (dgpessoa.SelectedRows.Count > 0)
            {
                // Pega a pessoa selecionada da DataGridView
                var pessoaSelecionada = dgpessoa.SelectedRows[0].DataBoundItem as Pessoa;

                // Verifica se a pessoa selecionada � v�lida
                if (pessoaSelecionada != null)
                {
                    // Cria o formul�rio de cadastro com a pessoa selecionada
                    frmCadastro formulario_Cadastro = new frmCadastro(pessoaSelecionada);

                    // Exibe o formul�rio de edi��o como um modal (espera o retorno antes de continuar)
                    formulario_Cadastro.ShowDialog();

                    // Ap�s o fechamento do formul�rio, atualiza o grid com os dados mais recentes
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao obter os dados da pessoa. Tente novamente.");
                }
            }
            else
            {
                // Mensagem caso nenhuma linha tenha sido selecionada
                MessageBox.Show("Selecione uma pessoa para editar.");
            }
        }
    }
}