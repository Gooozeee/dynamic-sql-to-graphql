using System.ComponentModel;

namespace DynamicSqlToGraphQl.Domain.ValueObjects
{
    // Enumeration which holds all valid SQL Server Data types
    public enum SqlDataTypes
    {
        bigint,
        numeric,
        bit,
        smallint,
        [Description("decimal")]
        sqldecimal,
        smallmoney,
        [Description("int")]
        sqlint,
        tinyint,
        money,
        [Description("float")]
        sqlfloat,
        real,
        date,
        datetimeoffset,
        datetime2,
        smalldatetime,
        datetime,
        time,
        [Description("char")]
        sqlchar,
        varchar,
        text,
        nchar,
        nvarchar,
        ntext,
        cursor,
        rowversion,
        hierarchyid,
        uniqueidentifier,
        [Description("sql_variant")]
        sqlvariant,
        xml,
        table
    }
}
