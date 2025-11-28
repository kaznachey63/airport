using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace AirportApp.Infrastructure
{
    /// <summary>
    /// Методы расширения для типобезопасной привязки данных в Windows Forms с поддержкой валидации
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Метод для  для типобезопасной привязки через выражения
        /// </summary>
        /// <typeparam name="TControl">Тип элемента управения</typeparam>
        /// <typeparam name="TControlProperty">Тип свойства источника данных</typeparam>
        /// <typeparam name="TSource">Тип элементов исходной коллекции</typeparam>
        /// <typeparam name="TSourceProperty">Тип свойства элемента для проекции</typeparam>
        /// <param name="control">Экземпляр элемента управления Windows Forms, к которому применяется привязка</param>
        /// <param name="controlProperty">Выражение, указывающее, какое свойство контрола будет связано с данными</param>
        /// <param name="dataSource">Объект-источник данных, содержащий информацию для отображения</param>
        /// <param name="sourceProperty">Выражение, указывающее, какое свойство источника данных использовать</param>
        /// <param name="errorProvider">Элемент ErrorProvider формы, по умолчанию null</param>
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

            if (controlPropertyName == null || sourcePropertyName == null)
            {
                return;
            }

            control.DataBindings.Add(controlPropertyName, dataSource, sourcePropertyName);

            if (errorProvider != null)
            {
                // Инициализация: проверить ошибку сейчас
                UpdateErrorForProperty(control, dataSource, sourcePropertyName, errorProvider);

                // Подписка: обновлять ошибку при валидации контрола
                control.Validating += (s, e) =>
                {
                    UpdateErrorForProperty(control, dataSource, sourcePropertyName, errorProvider);
                    e.Cancel = false;
                };
            }
        }

        private static void UpdateErrorForProperty<TSource>(
            Control control,
            TSource dataSource,
            string propertyName,
            ErrorProvider errorProvider)
            where TSource : class
        {
            var context = new ValidationContext(dataSource);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(dataSource, context, results, true);

            var error = results.FirstOrDefault(r => r.MemberNames.Contains(propertyName));
            errorProvider.SetError(control, error?.ErrorMessage ?? "");
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
