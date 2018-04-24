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
        private SqlDataReader _reader = null;
        private SqlDataAdapter _adapter = null;
        private DataTable _dataTable = null;
        private string _ConnectionString = null;
        public DMLService(string ConnectionString)
        {
            this._ConnectionString = ConnectionString;
        }
        private void ConfigureConnection()
        {
            this._connection = new SqlConnection(this._ConnectionString);
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
        public SqlCommand ConfigureParameter(List<VMParameter> parameters)
        {
            return this.ConfigureParameter(this._command, parameters);
        }
        public SqlCommand ConfigureParameter(SqlCommand command, List<VMParameter> parameters)
        {
            try
            {
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
                            command.Parameters.Add(param);
                        }
                    }
                }
                return command;
            }
            catch
            {
                return null;
            }
        }
        public SqlCommand ConfigureCommand(string commandText, CommandType commandType)
        {
            return this.ConfigureCommand(commandText, commandType);
        }
        public SqlCommand ConfigureCommand(string commandText, CommandType commandType, List<VMParameter> parameters)
        {
            try
            {
                if (!this.IsValidateConnection()) return null;
                this._command = new SqlCommand();
                this._command.Connection = this._connection;
                this._command.CommandText = commandText;
                this._command.CommandType = commandType;
                if (this.ConfigureParameter(this._command, parameters) == null) return null;
                return this._command;
            }
            catch
            {
                return null;
            }
        }
        public DataTable ConfigureAdapter(SqlCommand command)
        {
            if (command == null) return null;
            try
            {
                if (!IsValidateConnection()) return null;
                this._adapter = new SqlDataAdapter(command);
                this._dataTable = new DataTable();
                this._adapter.Fill(this._dataTable);
                if (this._dataTable == null) return null;
                return this._dataTable;
            }
            catch
            {
                return null;
            }
        }
        public DataTable ConfigureAdapter(string commandText, CommandType commandType)
        {
            return this.ConfigureAdapter(commandText, commandType);
        }
        public DataTable ConfigureAdapter(string commandText, CommandType commandType, List<VMParameter> parameters)
        {
            try
            {
                if (!IsValidateConnection()) return null;
                SqlCommand command = this.ConfigureCommand(commandText, commandType, parameters);
                if (command == null) return null;
                this._adapter = new SqlDataAdapter(command);
                this._dataTable = new DataTable();
                this._adapter.Fill(this._dataTable);
                if (this._dataTable == null) return null;
                return this._dataTable;
            }
            catch
            {
                return null;
            }
        }
        public SqlDataReader ConfigureReader(SqlCommand command)
        {
            if (command == null) return null;
            try
            {
                if (!IsValidateConnection()) return null;
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                return null;
            }
        }
    }
}
