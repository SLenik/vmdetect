using System;

namespace TTC.Utils.Environment.Entities
{
    /// <summary>
    /// Указание, какому свойству сущности соответствует поле объекта WMI.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class WmiResultAttribute : Attribute
    {
        public WmiResultAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }

        /// <summary>
        /// Имя поля в объекте WMI.
        /// </summary>
        public string PropertyName { get; }
    }
}
