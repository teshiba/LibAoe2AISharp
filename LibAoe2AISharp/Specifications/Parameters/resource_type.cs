namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Resource type.
    /// <para>
    /// The types Used in
    /// <see cref="dropsite_min_distance"/>
    /// has been added by UserPatch.
    /// </para>
    /// </summary>
    public enum resource_type
    {
        /// <summary>
        /// Food : 食料
        /// </summary>
        food,

        /// <summary>
        /// Gold : 金
        /// </summary>
        gold,

        /// <summary>
        /// Stone : 石
        /// </summary>
        stone,

        /// <summary>
        /// Wood : 木
        /// </summary>
        wood,

#if USER_PATCH //extended user patch
        /// <summary>
        /// 狩の獲物
        /// (extended user patch)
        /// </summary>
        hunting,

        /// <summary>
        /// boar while hunting : 狩中の猪
        /// (user patch)
        /// </summary>
        boar_hunting,

        /// <summary>
        /// deer while hunting : 狩中の鹿
        /// (user patch)
        /// </summary>
        deer_hunting,

        /// <summary>
        /// live boar : 活きている猪
        /// (user patch)
        /// </summary>
        live_boar,
#endif // USER_PATCH
    }
}
