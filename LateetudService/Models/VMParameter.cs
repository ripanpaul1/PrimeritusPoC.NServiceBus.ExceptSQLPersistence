using System.Data;

namespace LateetudService.Models
{
    public class VMParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public SqlDbType DataType { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; }

        public VMParameter(string Name, string Value, SqlDbType DataType)
        {
            this.Name = Name;
            this.Value = Value;
            this.DataType = DataType;
            this.Size = 0;
            this.Direction = ParameterDirection.Input;
        }

        public VMParameter(string Name, string Value, SqlDbType DataType, ParameterDirection Direction)
        {
            this.Name = Name;
            this.Value = Value;
            this.DataType = DataType;
            this.Size = 0;
            this.Direction = Direction;
        }

        public VMParameter(string Name, string Value, SqlDbType DataType, int Size)
        {
            this.Name = Name;
            this.Value = Value;
            this.DataType = DataType;
            this.Size = Size;
            this.Direction = ParameterDirection.Input;
        }

        public VMParameter(string Name, string Value, SqlDbType DataType, int Size, ParameterDirection Direction)
        {
            this.Name = Name;
            this.Value = Value;
            this.DataType = DataType;
            this.Size = Size;
            this.Direction = Direction;
        }
    }
}
