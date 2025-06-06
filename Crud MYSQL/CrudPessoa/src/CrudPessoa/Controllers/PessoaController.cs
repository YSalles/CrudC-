﻿using CrudPessoa.Core.Repositories;
using CrudPessoa.Models;

namespace CrudPessoa.Controllers
{
    public class PessoaController
    {
        // Declara o repositório como campo privado
        private readonly PessoaRepository _pessoaRepository;

        // Construtor que recebe o repositório como dependência
        public PessoaController()
        {
            _pessoaRepository = new PessoaRepository();
        }

        // Método para obter todas as pessoas
        public List<Pessoa> GetPessoas()
        {
            // Chama o método do repositório para obter as pessoas
            return _pessoaRepository.BuscarTodasPessoas();
        }

        // Método para cadastrar uma nova pessoa
        public bool CadastrarPessoa(string nome, string cpf, string email)
        {
            // Cria uma nova pessoa com os dados fornecidos
            Pessoa Nova_pessoa = new Pessoa(0, nome, email, cpf);

            // Chama o método do repositório para cadastrar a pessoa
            return _pessoaRepository.CadastrarPessoa(Nova_pessoa);
        }

        // Método para excluir uma pessoa
        public bool DeletarPessoa(int id)
        {
            return _pessoaRepository.DeletarPessoa(id);
        }

        // Método para editar uma pessoa
        public bool EditarPessoa(int id, string nome, string cpf, string email)
        {
            Pessoa edicao_pessoa = new Pessoa(id, nome, email, cpf); // Cria a pessoa com o ID já existente
            return _pessoaRepository.EditarPessoa(edicao_pessoa); // Passa para o repositório realizar o update
        }
    }
}