namespace Springboard365.Core
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public class AttributeUtilities : IAttributeUtilities
    {
        public TAttribute GetAttributeFor<TAttribute, TTargetType>(Expression<Func<TTargetType, object>> expression)
            where TAttribute : Attribute
        {
            var memberExpression = GetPropertyOrMethodExpression(expression);

            if (memberExpression == null)
            {
                throw new ArgumentException("Unsupported expression type. Expression must be resolvable against a member or property.");
            }

            return GetAttributeAgainstMemberExpression<TAttribute, TTargetType>(memberExpression.Member.Name);
        }

        private static TAttribute GetAttributeAgainstMemberExpression<TAttribute, TTargetType>(string memberOrPropertyName)
            where TAttribute : Attribute
        {
            var memberInfo = typeof(TTargetType).GetMember(memberOrPropertyName).FirstOrDefault();

            if (memberInfo == null)
            {
                return null;
            }

            return memberInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;
        }

        private static MemberExpression GetPropertyOrMethodExpression<TTargetType>(Expression<Func<TTargetType, object>> expression)
        {
            var body = expression.Body as MemberExpression;

            if (body != null)
            {
                return body;
            }

            var ubody = (UnaryExpression)expression.Body;
            return ubody.Operand as MemberExpression;
        }
    }
}