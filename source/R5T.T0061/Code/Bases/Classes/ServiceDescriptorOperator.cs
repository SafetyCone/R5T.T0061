using System;


namespace R5T.T0061
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDescriptorOperator : IServiceDescriptorOperator
    {
        #region Static
        
        public static ServiceDescriptorOperator Instance { get; } = new();

        #endregion
    }
}