using System;

namespace Based_System_for_Storing_School_Data
{
    internal class Teacher
    {
        private object @object;
        private string v;

        public Teacher(object @object, string v)
        {
            this.@object = @object;
            this.v = v;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        internal string GetName()
        {
            throw new NotImplementedException();
        }
    }
}