using System;
using System.Linq.Expressions;

namespace Castle.DynamicLinqQueryBuilder
{
    /// <summary>
    /// This interface is used to define a custom filter operator
    /// </summary>
    public interface IFilterOperator
    {
        /// <summary>
        /// Custom operator name
        /// </summary>
        string Operator { get; }

        /// <summary>
        /// Get Custom Expression
        /// </summary>
        /// <param name="type"></param>
        /// <param name="rule"></param>
        /// <param name="propertyExp"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        Expression GetExpression(Type type, IFilterRule rule, Expression propertyExp, BuildExpressionOptions options);
    }
}
