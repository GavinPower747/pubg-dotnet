using System;

namespace Pubg.Net.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class RelatedEnitityAttribute : Attribute
    {
        public string EntityName { get; set; }

        internal RelatedEnitityAttribute(string entityName)
        {
            EntityName = entityName;
        }
    }
}
