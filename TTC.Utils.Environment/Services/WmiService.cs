using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using TTC.Utils.Environment.Entities;
using TTC.Utils.Environment.Interfaces;
using TTC.Utils.Environment.Queries;

namespace TTC.Utils.Environment.Services
{
    /// <summary>
    /// Сервис получения данных Windows Management Instrumentation (WMI).
    /// </summary>
    public class WmiService : IWmiService
    {
        /// <summary>
        /// Извлечение заданных в запросе столбцов из полученных записей WMI с приведением типов.
        /// </summary>
        /// <typeparam name="TResult">Тип сущности, в которую выгружаются результаты запроса.</typeparam>
        /// <param name="managementObject">Объект, полученный в результате запроса WMI.</param>
        /// <returns>Сущность с результатами запроса.</returns>
        private static TResult Extract<TResult>(ManagementBaseObject managementObject)
            where TResult : class, new()
        {
            var result = new TResult();
            foreach (var property in typeof(TResult).GetProperties())
            {
                var wmiAttribute = (WmiResultAttribute)Attribute.GetCustomAttribute(property, typeof(WmiResultAttribute));
                if (wmiAttribute != null)
                {
                    var sourceValue = managementObject.Properties[wmiAttribute.PropertyName].Value;
                    var targetType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    object targetValue;
                    if (sourceValue == null)
                    {
                        targetValue = null;
                    }
                    else if (targetType == typeof(DateTime))
                    {
                        targetValue = ManagementDateTimeConverter.ToDateTime(sourceValue.ToString()).ToUniversalTime();
                    }
                    else if (targetType == typeof(Guid))
                    {
                        targetValue = Guid.Parse(sourceValue.ToString());
                    }
                    else
                    {
                        targetValue = Convert.ChangeType(
                            managementObject.Properties[wmiAttribute.PropertyName].Value, targetType);
                    }
                    property.SetValue(result, targetValue);
                }
            }
            return result;
        }

        /// <summary>
        /// Получение набора данных из указанного запроса к WMI.
        /// </summary>
        /// <param name="selectQuery">Запрос для получения данных.</param>
        /// <param name="searcher">Существующий объект для выполнения запросов к WMI.</param>
        /// <returns>Результирующая коллекция объектов в таблице.</returns>
        private ManagementObjectCollection QueryAll(SelectQuery selectQuery, ManagementObjectSearcher searcher = null)
        {
            searcher = searcher ?? new ManagementObjectSearcher();
            searcher.Query = selectQuery;
            return searcher.Get();
        }

        /// <summary>
        /// Получение первой строки данных из указанного запроса к WMI.
        /// </summary>
        /// <param name="selectQuery">Запрос для получения данных.</param>
        /// <param name="searcher">Существующий объект для выполнения запросов к WMI.</param>
        /// <returns>Результирующая коллекция объектов в таблице.</returns>
        private ManagementBaseObject QueryFirst(SelectQuery selectQuery, ManagementObjectSearcher searcher = null)
        {
            return QueryAll(selectQuery, searcher).Cast<ManagementBaseObject>().FirstOrDefault();
        }

        public TResult QueryFirst<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new()
        {
            var managementObject = QueryFirst(wmiQuery.SelectQuery);
            return managementObject == null ? null : Extract<TResult>(managementObject);
        }

        public IReadOnlyCollection<TResult> QueryAll<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new()
        {
            var managementObjects = QueryAll(wmiQuery.SelectQuery);

            return managementObjects?.Cast<ManagementBaseObject>()
                .Select(Extract<TResult>)
                .ToList();
        }
    }
}
