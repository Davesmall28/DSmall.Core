namespace Springboard365.Core
{
    using System;
    using System.Linq.Expressions;

    public interface IAttributeUtilities
    {
        TAttribute GetAttributeFor<TAttribute, TTargetType>(Expression<Func<TTargetType, object>> expression)
            where TAttribute : Attribute;
    }
}