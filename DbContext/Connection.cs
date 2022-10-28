

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace TesteInsereAutoConclusao
{
    public class Connection
    {
        private IDataParameterCollection _paramCollection;
        private IDbConnection _connection;
        private IDbCommand _command;
        private string _stringConnection;
        private string _stringConnectionImage;
        string conn = string.Empty;

        public Connection()
        {

        }

        public Connection(string connection)
        {
            StringConexao(connection);
            conn = connection;
        }

        #region Método responsável por verificar a conexão com o banco de dados
        public bool StringConexao(string StrConn)
        {
            try
            {
                if (string.IsNullOrEmpty(StrConn)) return false;

                //string conecta = StrConn.Replace("Provider=SQLNCLI11;", "");
                //_connection = new SqlConnection(StrConn);
                _connection = new SqlConnection(StrConn);
                _connection.Open();

                if (_connection == null)
                {
                    return false;
                }
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        #endregion

        #region Método responsável por [RETORNAR A STRING DE CONEXÃO]
        public string GetStringConnection()
        {
            return conn;
        }
        #endregion

        #region Método responsável por [LIMPAR PARÂMETROS]
        public IDbConnection CreateConnection(string connection)
        {
            return new SqlConnection(connection.Replace("Provider=SQLNCLI11;", ""));
        }
        #endregion

        #region Método responsável por [LIMPAR PARÂMETROS]
        public void ClearParameter()
        {
            _paramCollection.Clear();
        }
        #endregion

        #region Método responsável por [ADICIONAR UM PARÂMETRO]
        public void AddParameter(string name, object value)
        {
            _paramCollection.Add(new SqlParameter(name, value));
        }
        #endregion

        #region Peristencia dados, alterar, excluir e inserir
        public DataTable ExecuteReader(CommandType commandType, String sql)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                //Criar o comando que vai levar a informação para o banco
                _command = ((SqlConnection)_connection).CreateCommand();

                //Colocando as informações dentro do comando
                _command.CommandType = commandType;
                _command.CommandText = sql;
                _command.CommandTimeout = 7200;

                foreach (SqlParameter SqlParameter in _paramCollection)
                {
                    _command.Parameters.Add(new SqlParameter(SqlParameter.ParameterName, SqlParameter.Value));
                }

                // Executa o comando, ou seja, mandar o comando ir até o banco de dados

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter((SqlCommand)_command);

                //Preenche o Data Table com o Retorno da rotina
                SqlDataAdapter.Fill(dataTable);
                // Executa a rotina
                return dataTable;
            }
            catch (SqlException Ex)
            {
                return null;
            }
        }
        #endregion

        #region Método responsável por [RETORNAR UM DATA READER]
        public IDataReader GetDataReader(CommandType commandType, string sql, string connection)
        {
            IDataReader DtReader = null;
            try
            {
                _connection = new SqlConnection(GetStringConnection().Replace("Provider=SQLNCLI11;", ""));

                try
                {
                    if (_connection.State == ConnectionState.Closed)
                    {
                        //_command.CommandTimeout = 0;
                        _connection.Open();
                    }

                    _command = ((IDbConnection)_connection).CreateCommand(); // existe 
                    //command = (connection as IDbConnection).CreateCommand();
                    _command.CommandType = commandType;
                    _command.CommandText = sql;
                    _command.CommandTimeout = 7200;
                    DtReader = (IDataReader)_command.ExecuteReader();


                    // Executa a rotina
                    return DtReader;
                }
                catch (Exception Ex)
                {
                    return null;
                }
            }

            catch (SqlException Ex)
            {
                _connection.Close();
                return null;
            }
            //finally
            //{
            //    _connection.Close();
            //}
        }
        #endregion

        #region Método responsável por [RETORNAR UM DATA READER]
        public List<string> GetList(string sql, string conn)
        {
            List<string> list = new List<string>();
            try
            {
                IDataReader dataReader = null;

                // Instância o DataReader e Retorna as informações
                dataReader = GetDataReader(CommandType.Text, sql, conn);
                if (dataReader is null) return new List<string>();
                while (dataReader.Read())
                    list.Add(Convert.ToString(dataReader[0]));
            }
            catch { }
            return list;
        }
        #endregion
    }
}