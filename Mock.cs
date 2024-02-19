using System;

namespace Based_System_for_Storing_School_Data
{
    internal class Mock<T>
    {
        public Mock()
        {
        }

        public object Object { get; internal set; }

        internal object Setup(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}