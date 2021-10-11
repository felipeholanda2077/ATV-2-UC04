using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ATV_2_UC4.Models
{
    public class PacotesTuristicosRepository
    {
        private const string DadosConexao = "Database=atv2_uc04; Data Source=localhost; User Id=root;";


          public PacotesTuristicos ValidarLogin(PacotesTuristicos pt){
          
          MySqlConnection Conexao = new MySqlConnection(DadosConexao);
          Conexao.Open();
          
          String Query = "select * from PacotesTuristicos where Nome=@Nome and Origem=@Origem";

          MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

          Comandopt.Parameters.AddWithValue("@Nome",pt.Nome);
          Comandopt.Parameters.AddWithValue("@Origem",pt.Origem);

          MySqlDataReader ReaderPt = Comandopt.ExecuteReader();

          PacotesTuristicos PacoteEncontrado = null;
          if (ReaderPt.Read()){

            PacoteEncontrado = new PacotesTuristicos();
            PacoteEncontrado.Id = ReaderPt.GetInt32("Id");
             
           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Nome")))
             PacoteEncontrado.Nome = ReaderPt.GetString("Nome");
           
           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Origem")))
             PacoteEncontrado.Origem = ReaderPt.GetString("Origem");

           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Destino")))
             PacoteEncontrado.Destino = ReaderPt.GetString("Destino");

           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Atrativos")))
             PacoteEncontrado.Atrativos = ReaderPt.GetString("Atrativos");

            PacoteEncontrado.Saida = ReaderPt.GetDateTime("Saida");
            PacoteEncontrado.Retorno = ReaderPt.GetDateTime("Retorno");
          }
          
          Conexao.Close();
          return PacoteEncontrado;
        }

        public PacotesTuristicos BuscarPorIdPT(int Id){
          
          MySqlConnection Conexao = new MySqlConnection(DadosConexao);
          Conexao.Open();
          
          String Query = "select * from PacoteTuristicos where Id=@Id";

          MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

          Comandopt.Parameters.AddWithValue("@Id",Id);

          MySqlDataReader ReaderPt = Comandopt.ExecuteReader();

          PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();
          if (ReaderPt.Read()){
            PacoteEncontrado.Id = ReaderPt.GetInt32("Id");
             
           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Nome")))
             PacoteEncontrado.Nome = ReaderPt.GetString("Nome");
           
           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Origem")))
             PacoteEncontrado.Origem = ReaderPt.GetString("Origem");

           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Destino")))
             PacoteEncontrado.Destino = ReaderPt.GetString("Destino");

           if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Atrativos")))
             PacoteEncontrado.Atrativos = ReaderPt.GetString("Atrativos");

            PacoteEncontrado.Saida = ReaderPt.GetDateTime("Saida");
            PacoteEncontrado.Retorno = ReaderPt.GetDateTime("Retorno");
          }
          
          Conexao.Close();
          
          return PacoteEncontrado;

        }


        public List<PacotesTuristicos> ListarPT(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

           String Query = "select * from PacotesTuristicos";

           MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

           MySqlDataReader ReaderPt = Comandopt.ExecuteReader();

           List<PacotesTuristicos> ListaPt = new List<PacotesTuristicos>();

           while(ReaderPt.Read()){

               PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();
               PacoteEncontrado.Id = ReaderPt.GetInt32("Id");

               if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Nome")))
                 PacoteEncontrado.Nome = ReaderPt.GetString("Nome");
               
               if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Origem")))
                 PacoteEncontrado.Origem = ReaderPt.GetString("Origem");
               
               if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Destino")))
                 PacoteEncontrado.Destino = ReaderPt.GetString("Destino");

               if (!ReaderPt.IsDBNull(ReaderPt.GetOrdinal("Atrativos")))
                 PacoteEncontrado.Atrativos = ReaderPt.GetString("Atrativos");
               
               
               PacoteEncontrado.Saida = ReaderPt.GetDateTime("Saida");
               PacoteEncontrado.Retorno = ReaderPt.GetDateTime("Retorno");
               
               ListaPt.Add(PacoteEncontrado);
           }

           Conexao.Close();

           return ListaPt;
        }

        public void CadastrarPT(PacotesTuristicos pt){

           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
           Conexao.Open();

           String Query = "Insert into PacotesTuristicos (Nome,Origem,Destino,Atrativos,Saida,Retorno) values (@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno)";

           MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

           Comandopt.Parameters.AddWithValue("@Nome", pt.Nome);
           Comandopt.Parameters.AddWithValue("@Login", pt.Origem);
           Comandopt.Parameters.AddWithValue("@Destino", pt.Destino);
           Comandopt.Parameters.AddWithValue("@Atrativos", pt.Atrativos);
           Comandopt.Parameters.AddWithValue("@Saida", pt.Saida);
           Comandopt.Parameters.AddWithValue("@Retorno", pt.Retorno);

           Comandopt.ExecuteNonQuery();

           Conexao.Close();

        }


        public void EditarPT(PacotesTuristicos pt){

           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
           Conexao.Open();

           String Query = "update PacotesTuristicos set Nome=@Nome, Origem=@Origem, Destino=@Destino, Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno where Id=@Id";

           MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

           Comandopt.Parameters.AddWithValue("@Id", pt.Id);
           Comandopt.Parameters.AddWithValue("@Nome", pt.Nome);
           Comandopt.Parameters.AddWithValue("@Origem", pt.Origem);
           Comandopt.Parameters.AddWithValue("@Destino", pt.Destino);
           Comandopt.Parameters.AddWithValue("@Atrativos", pt.Atrativos);
           Comandopt.Parameters.AddWithValue("@Saida", pt.Saida);
           Comandopt.Parameters.AddWithValue("@Retorno", pt.Retorno);

           Comandopt.ExecuteNonQuery();

           Conexao.Close();

        }


        public void ExcluirPT(PacotesTuristicos pt){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "delete from PacotesTuristicos where Id=@Id";

            MySqlCommand Comandopt = new MySqlCommand(Query,Conexao);

            Comandopt.Parameters.AddWithValue("@Id", pt.Id);

            Comandopt.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}