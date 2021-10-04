using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ATV_2_UC4.Models
{
    public class UsuarioRepository
    {
        //objetivo: é criar as funcionalidades/métodos que manipulam os 
        //atributos da classe Usuario

        //Cadastrar,Listar,Alterar,Editar,Excluir - CRUD (C - create, R - read, U - update, D - Delete
        
        //definir as credencias do banco de dados
        private const string DadosConexao = "Database=atv2_uc04; Data Source=localhost; User Id=root;";

        public void TestarConexao(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();

        }
    }
}