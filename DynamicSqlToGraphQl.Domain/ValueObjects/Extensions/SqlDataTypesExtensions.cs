using DynamicSqlToGraphQl.Domain.ValueObjects;
using System.ComponentModel;
using System.Reflection;

namespace DynamicSqlToGraphQl.Application.Extensions
{
    // Extensions on enum values so that the descriptions can be retrieved as the value
    public static class SqlDataTypesExtensions
    {
        // Retrieving the description of an enum value if it has one, if not it will return the actual enum value
        private static string ToDescription(Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = Attribute.GetCustomAttribute(field!, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        // Gets the integer of an enum value if it exists, if not, returns -1
        public static int GetIntEnumValue(string value)
        {
            for (int i = 0; i < Enum.GetValues(typeof(SqlDataTypes)).Length; i++)
            {
                string description = ToDescription((SqlDataTypes)i);
                if (value.ToLower().Equals(description.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
