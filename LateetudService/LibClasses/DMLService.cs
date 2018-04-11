using LateetudService.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LateetudService.LibClasses
{
    public class DMLService
    {
        private SqlConnection _connection = null;
        private SqlCommand _command = null;
        SqlDataAdapter _adapter = null;
        private DataTable _dataTable = null;

        private string _ConnectionString { get; set; }

        public DMLService(string ConnectionString)
        {
            this._ConnectionString = ConnectionString;
        }

        private void ConfigureConnection()
        {
            this._connection = new SqlConnection(this._ConnectionString);
        }

        public SqlCommand ConfigureCommand(string commandText, CommandType commandType)
        {
            return this.ConfigureCommand(commandText, commandType);
        }
        public SqlCommand ConfigureCommand(string commandText, CommandType commandType, List<VMParameter> parameters)
        {
            try
            {
                if (!IsValidateConnection()) return null;
                this._command = new SqlCommand();
                this._command.Connection = this._connection;
                this._command.CommandText = commandText;
                this._command.CommandType = commandType;

                if (parameters != null)
                {
                    if (parameters.Count > 0)
                    {
                        foreach (var parameter in parameters)
                        {
                            SqlParameter param = new SqlParameter();
                            param.ParameterName = parameter.Name;
                            param.Value = parameter.Value;
                            param.SqlDbType = parameter.DataType;
                            if (parameter.DataType == SqlDbType.Char || parameter.DataType == SqlDbType.VarChar)
                                param.Size = parameter.Size;
                            param.Direction = parameter.Direction;
                        }
                    }
                }
                return this._command;
            }
            catch
            {
                return null;
            }
        }

        public DataTable ConfigureAdapter()
        {
            return this.ConfigureAdapter(this._command);
        }
        public DataTable ConfigureAdapter(SqlCommand command)
        {
            try
            {
                if (!IsValidateConnection()) return null;
                this._adapter = new SqlDataAdapter(command);
                this._dataTable = new DataTable();
                this._adapter.Fill(_dataTable);
                return this._dataTable;
            }
            catch
            {
                return null;
            }
        }

        private bool IsValidateConnection()
        {
            try
            {
                this.ConfigureConnection();
                if (this._connection.State == ConnectionState.Closed) this._connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
