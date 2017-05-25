namespace Springboard365.Core
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;

    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    [ExcludeFromCodeCoverage]
    public static class Guard
    {
        public static void NotNull<T>(T value)
            where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(GetParameterName(() => value), "Parameter cannot be null.");
            }
        }

        public static void NotNullOrEmpty(string value)
        {
            NotNull(value);
            if (value.Length > 0)
            {
                return;
            }

            var message = string.Format("Parameter '{0}' cannot be empty.", GetParameterName(() => value));
            throw new ArgumentException(message);
        }

        private static string GetParameterName<T>(Expression<Func<T>> memberExpression)
        {
            var expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}