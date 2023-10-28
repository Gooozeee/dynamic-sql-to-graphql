namespace DynamicSqlToGraphQl.Domain.Entities
{
    // Entity for modelling a table of a database
    public class DatabaseTable
    {
        public string TableName { get; set; }
        public List<DatabaseColumn> TableColumns { get; } = new List<DatabaseColumn>();

        public DatabaseTable(
            string tableName,
            List<DatabaseColumn> tableColumns)
        {
            TableName = tableName;
            setTableColumns(tableColumns);
        }

        public bool setTableColumns(List<DatabaseColumn> databaseColumns)
        {
            foreach (DatabaseColumn column in databaseColumns)
            {
                if (!TableColumns.Contains(column))
                {
                    TableColumns.Add(column);
                }
                else
                {
                    // TODO : Create exception handling middleware to ensure have a custom exception for this
                    throw new Exception($"The table column with name {column.ColumnName} already exists");
                } 
            }
            return true;
        }
    }
}
