using System;

namespace XamarinFormsUIs.Converters
{
    /// <summary>
    /// When annotated onto an IValueConverter implementation, enables third party tools to analyse the type-flow of binding expressions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ValueConversionAttribute : Attribute
    {
        public ValueConversionAttribute(Type input, Type output)
        {
        }

        public Type ParameterType
        {
            get;
            set;
        }
    }
}