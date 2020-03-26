namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// research state.
    /// </summary>
    public enum ResearchState
    {
        /// <summary>
        /// Research finished.
        /// </summary>
        Finished,

        /// <summary>
        /// Researching.
        /// </summary>
        Researching,

        /// <summary>
        /// Not researching now.
        /// </summary>
        NotResearching,
    }

    /// <summary>
    /// valid wall perimeter.
    /// <para>
    /// 1 is closer to the Town Center than 2.
    /// </para>
    /// </summary>
    public enum Perimeter
    {
        /// <summary>
        /// Perimeter 1 is usually between 10 and 20 tiles from the starting Town Center.
        /// </summary>
        Near = 1,

        /// <summary>
        /// Perimeter 2 is usually between 18 and 30 tiles from the starting Town Center.
        /// </summary>
        Far = 2,
    }
}