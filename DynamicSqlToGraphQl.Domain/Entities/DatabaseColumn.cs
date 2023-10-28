using DynamicSqlToGraphQl.Application.Extensions;
using DynamicSqlToGraphQl.Domain.ValueObjects;

namespace DynamicSqlToGraphQl.Domain.Entities
{
    // Entity for modelling a column of a database
    public class DatabaseColumn
    {
        public string ColumnName { get; set; }
        public SqlDataTypes SqlColumnType { get; set; }

        public DatabaseColumn(
            string columnName,
            string sqlColumnType)
        {
            ColumnName = columnName;
            setColumnType(sqlColumnType);
        }

        public bool setColumnType(string columnType)
        {
            var enumIndex = SqlDataTypesExtensions.GetIntEnumValue(columnType);
            if (enumIndex != -1)
            {
                SqlColumnType = (SqlDataTypes)enumIndex;
                return true;
            }

            // TODO : Create a middleware to throw a column type exception here
            throw new Exception($"The column type {columnType} is invalid");
        }
    }
}
