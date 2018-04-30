using System;

namespace Pubg.Net.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class DefaultEnumMemberAttribute : Attribute
    {
    }
}
