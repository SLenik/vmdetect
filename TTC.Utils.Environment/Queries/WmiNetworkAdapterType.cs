namespace TTC.Utils.Environment.Queries
{
    /// <summary>
    /// Типы сетевых адаптеров, данные которых требуется получить.
    /// </summary>
    public enum WmiNetworkAdapterType
    {
        /// <summary>
        /// Любой тип адаптеров.
        /// </summary>
        All,

        /// <summary>
        /// Только физические адаптеры.
        /// </summary>
        Physical,

        /// <summary>
        /// Только виртуальные адаптеры.
        /// </summary>
        Virtual,
    }
}
