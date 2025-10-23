using System.Linq.Expressions;

namespace AirportApp.Infostructure
{
    public static class Extensions
    {
        public static void AddBinding
        <
            TControl,
            TControlProperty,
            TSource,
            TSourceProperty
        >
        (
            this TControl control,
            Expression<Func<TControl, TControlProperty>> controlProperty,
            TSource dataSource,
            Expression<Func<TSource, TSourceProperty>> sourceProperty,
            ErrorProvider? errorProvider = null
        )

        where TControl : Control
        where TSource : class
        {
            var controlPropertyName = GetPropertyName(controlProperty);
            var sourcePropertyName = GetPropertyName(sourceProperty);


        }

        private static string GetPropertyName<T, TProperty>(Expression<Func<T, TProperty>> sourceProperty)
        {
            if (sourceProperty.Body is MemberExpression member)
            {
                return member.Member.Name;
            }
            throw new ArgumentException("Expression must be a member access.", nameof(sourceProperty));
        }
    }
}
