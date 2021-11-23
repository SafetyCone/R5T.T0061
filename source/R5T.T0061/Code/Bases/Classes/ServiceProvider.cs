using System;


namespace R5T.T0061
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceProvider : IServiceProvider
    {
        #region Static
        
        public static ServiceProvider Instance { get; } = new();

        #endregion
    }
}