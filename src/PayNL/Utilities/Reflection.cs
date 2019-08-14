using System;

namespace PayNL.Utilities
{
    class Reflection
    {
        public static bool IsNullable(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
