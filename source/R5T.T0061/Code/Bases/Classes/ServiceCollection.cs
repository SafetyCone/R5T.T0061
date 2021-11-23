using System;


namespace R5T.T0061
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceCollection : IServiceCollection
    {
        #region Static
        
        public static ServiceCollection Instance { get; } = new();

        #endregion
    }
}