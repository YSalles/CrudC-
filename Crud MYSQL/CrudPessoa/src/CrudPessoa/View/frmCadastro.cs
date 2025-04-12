using CrudPessoa.Controllers;
using CrudPessoa.Models;

namespace CrudPessoa.View
{
    public partial class frmCadastro : Form
    {
        private PessoaController _pessoaController;
        private int _pessoaId = 0;

        public frmCadastro(Pessoa? pessoa = null)
        {
            // Inicia o formulário
            InitializeComponent();

            // Recebe os dados da pessoa quando abrir o modal para edição
            if (pessoa != null)
            {
                _pessoaId = pessoa.Id;
                edtNome.Text = pessoa.Nome;
                edtCPF.Text = pessoa.Cpf;
                edtEmail.Text = pessoa.Email;
            }
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados dos campos do formulário
            string nome = edtNome.Text;
            string cpf = edtCPF.Text;
            string email = edtEmail.Text;

            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pessoaController = new PessoaController();

            if (_pessoaId == 0) // Inserção
            {
                //// Chama o método de inserção no controlador
                bool sucesso = _pessoaController.CadastrarPessoa(nome, cpf, email);

                // Verifica se a inserção foi bem-sucedida
                if (sucesso)
                {
                    MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha o formulário após o cadastro
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a pessoa.");
                }
            }
            else // Edição
            {
                // Chama o controlador para editar
                var resultado = _pessoaController.EditarPessoa(this._pessoaId, nome, cpf, email);
                if (resultado)
                {
                    MessageBox.Show("Pessoa editada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao editar pessoa.");
                }
            }
        }
    }
}