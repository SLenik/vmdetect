using System.Management;

namespace TTC.Utils.Environment.Queries
{
    /// <summary>
    /// Базовый класс данных параметров запроса к WMI.
    /// </summary>
    public class WmiQueryBase
    {
        private readonly SelectQuery _selectQuery;

        /// <summary>
        /// Конструктор запроса к WMI.
        /// </summary>
        /// <param name="className">Название таблицы, к которой производится запрос.</param>
        /// <param name="condition">Условие запроса.</param>
        /// <param name="selectedProperties">Результирующие столбцы запроса.</param>
        protected WmiQueryBase(string className, 
            string condition = null, string[] selectedProperties = null)
        {
            _selectQuery = new SelectQuery(className, condition, selectedProperties);
        }

        /// <summary>
        /// Объект со сформированным SELECT-запросом к WMI.
        /// </summary>
        internal SelectQuery SelectQuery
        {
            get { return _selectQuery; }
        }
    }
}
