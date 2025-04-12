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

        private void AtualizaGrid() // Método para atualizar o DataGridView
        {
            // Atribui a lista de pessoas ao DataGridView
            dgpessoa.DataSource = _pessoaController.GetPessoas();

            // Definir o modo de seleção para selecionar a linha inteira
            dgpessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configura o estilo da célula selecionada
            dgpessoa.DefaultCellStyle.SelectionBackColor = Color.LightBlue;         // Cor de fundo da célula selecionada
            dgpessoa.DefaultCellStyle.SelectionForeColor = Color.Black;             // Cor do texto da célula selecionada

            // Desabilita a seleção das colunas (deixa apenas a linha selecionada)
            dgpessoa.AllowUserToAddRows = false; // Impede a seleção de colunas ao adicionar uma nova linha
            dgpessoa.ColumnHeadersVisible = true;  // Garantir que o cabeçalho da coluna esteja visível

            // Oculta a primeira coluna do seletor de linha
            dgpessoa.RowHeadersVisible = false;

            // Desabilita a edição no DataGridView
            dgpessoa.ReadOnly = true;

            // Verifica se há colunas no DataGridView antes de personalizar
            if (dgpessoa.Columns.Count > 0)
            {
                dgpessoa.Columns["Id"].HeaderText = "Código";
                dgpessoa.Columns["Nome"].HeaderText = "Nome";
                dgpessoa.Columns["Cpf"].HeaderText = "CPF";
                dgpessoa.Columns["Email"].HeaderText = "E-mail";

                // Ajusta o tamanho automático das colunas
                dgpessoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Define a cor de fundo e texto das células
                dgpessoa.DefaultCellStyle.BackColor = Color.LightGray; ;
                dgpessoa.DefaultCellStyle.ForeColor = Color.Black;

                // Define alinhamento centralizado para a coluna 'Código'
                dgpessoa.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgpessoa.Columns["Id"].Width = 60;

                // Personaliza o cabeçalho
                dgpessoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dgpessoa.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dgpessoa.EnableHeadersVisualStyles = false;
            }
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de cadastro
            frmCadastro formulario_Cadastro = new frmCadastro();

            // Exibe o formulário de cadastro como um modal
            formulario_Cadastro.ShowDialog();

            // Após o formulário de cadastro ser fechado, atualiza o grid com os dados mais recentes
            AtualizaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fechar a aplicação
            this.Close();

            // Encerra a aplicação
            Application.Exit();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            if (dgpessoa.SelectedRows.Count > 0)
            {
                // Obtém o ID da pessoa selecionada (considerando que a coluna "Id" está na primeira posição)
                int idSelecionado = Convert.ToInt32(dgpessoa.SelectedRows[0].Cells["Id"].Value);

                // Pergunta ao usuário se tem certeza que deseja excluir
                var confirmacao = MessageBox.Show("Você tem certeza que deseja excluir esta pessoa?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    // Chama o repositório para deletar a pessoa
                    bool sucesso = _pessoaController.DeletarPessoa(idSelecionado);

                    if (sucesso)
                    {
                        MessageBox.Show("Pessoa excluída com sucesso.");
                        AtualizaGrid(); // Atualiza o grid após a exclusão
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
            // Verifica se há linhas selecionadas na DataGridView
            if (dgpessoa.SelectedRows.Count > 0)
            {
                // Pega a pessoa selecionada da DataGridView
                var pessoaSelecionada = dgpessoa.SelectedRows[0].DataBoundItem as Pessoa;

                // Verifica se a pessoa selecionada é válida
                if (pessoaSelecionada != null)
                {
                    // Cria o formulário de cadastro com a pessoa selecionada
                    frmCadastro formulario_Cadastro = new frmCadastro(pessoaSelecionada);

                    // Exibe o formulário de edição como um modal (espera o retorno antes de continuar)
                    formulario_Cadastro.ShowDialog();

                    // Após o fechamento do formulário, atualiza o grid com os dados mais recentes
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