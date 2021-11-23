using System;


namespace R5T.T0061
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDescriptor : IServiceDescriptor
    {
        #region Static
        
        public static ServiceDescriptor Instance { get; } = new();

        #endregion
    }
}