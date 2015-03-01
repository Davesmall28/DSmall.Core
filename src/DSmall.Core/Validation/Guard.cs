namespace DSmall.Core
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;

    /// <summary>The guard.</summary>
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    [ExcludeFromCodeCoverage]
    public static class Guard
    {
        /// <summary>The not null.</summary>
        /// <param name="reference">The reference.</param>
        /// <param name="value">The value.</param>
        /// <typeparam name="T">The parameter type.</typeparam>
        public static void NotNull<T>(Expression<Func<T>> reference, T value)
            where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(GetParameterName(reference), "Parameter cannot be null.");
            }
        }

        /// <summary>The not null or empty.</summary>
        /// <param name="reference">The reference.</param>
        /// <param name="value">The value.</param>
        public static void NotNullOrEmpty(Expression<Func<string>> reference, string value)
        {
            NotNull(reference, value);
            if (value.Length > 0)
            {
                return;
            }

            var message = string.Format("Parameter '{0}' cannot be empty.", GetParameterName(reference));
            throw new ArgumentException(message);
        }

        private static string GetParameterName<T>(Expression<Func<T>> memberExpression)
        {
            var expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}