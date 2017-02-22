using System.Collections.Generic;
using TTC.Utils.Environment.Queries;

namespace TTC.Utils.Environment.Interfaces
{
    /// <summary>
    /// ��������� ������� ��������� ������ Windows Management Instrumentation (WMI).
    /// </summary>
    public interface IWmiService
    {
        /// <summary>
        /// ��������� ������ ������ �� ���������� ������� � WMI.
        /// </summary>
        /// <typeparam name="TResult">��� ��������, � ������� ����������� ���������� �������.</typeparam>
        /// <param name="wmiQuery">������, ���������� ��������� WMI-�������.</param>
        /// <returns>�������� � ������������ �������.</returns>
        TResult QueryFirst<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new();

        /// <summary>
        /// ��������� ������ ������� �� ���������� ������� � WMI.
        /// </summary>
        /// <typeparam name="TResult">��� ��������, � ������� ����������� ���������� �������.</typeparam>
        /// <param name="wmiQuery">������, ���������� ��������� WMI-�������.</param>
        /// <returns>��������� ��������� � ������������ �������.</returns>
        IReadOnlyCollection<TResult> QueryAll<TResult>(WmiQueryBase wmiQuery)
            where TResult : class, new();
    }
}