using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace SmallStep09.Model
{
    public class Observable<T> : INotifyPropertyChanged where T : Observable<T>
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected static PropertyChangedEventArgs CreateChangeArgs(
            Expression<Func<T, object>> propertyExpression)
        {
            var lambda = propertyExpression as LambdaExpression;
            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = lambda.Body as UnaryExpression;
                memberExpression = unaryExpression.Operand as MemberExpression;
            }
            else
            {
                memberExpression = lambda.Body as MemberExpression;
            }

            var propertyInfo = memberExpression.Member as PropertyInfo;

            return new PropertyChangedEventArgs(propertyInfo.Name);
        }

        protected void NotifyChange(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }
    }
}