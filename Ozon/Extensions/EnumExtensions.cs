using System.Runtime.Serialization;
namespace Ozon.Extensions;

public static class EnumExtensions
{
    public static string ToApiString(this Enum value)
    {
        var type = value.GetType();
        var member = type.GetMember(value.ToString());

        if (member.Length > 0)
        {
            var attr = member[0].GetCustomAttribute<EnumMemberAttribute>();
            if (attr != null)
                return attr.Value;
        }

        return value.ToString();
    }
}