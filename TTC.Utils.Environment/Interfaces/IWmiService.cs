using System.Collections.Generic;
using TTC.Utils.Environment.Queries;

namespace TTC.Utils.Environment.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса получения данных Windows Management Instrumentation (WMI).
    /// </summary>
    public interface IWmiService
    {
        /// <summary>
        /// Получение первой записи из указанного запроса к WMI.
        /// </summary>
        /// <typeparam name="TResult">Тип сущности, в которую выгружаются результаты запроса.</typeparam>
        /// <param name="wmiQuery">Объект, содержащий параметры WMI-запроса.</param>
        /// <returns>Сущность с результатами запроса.</returns>
        TResult QueryFirst<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new();

        /// <summary>
        /// Получение набора записей из указанного запроса к WMI.
        /// </summary>
        /// <typeparam name="TResult">Тип сущности, в которую выгружаются результаты запроса.</typeparam>
        /// <param name="wmiQuery">Объект, содержащий параметры WMI-запроса.</param>
        /// <returns>Коллекция сущностей с результатами запроса.</returns>
        IReadOnlyCollection<TResult> QueryAll<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new();
    }
}