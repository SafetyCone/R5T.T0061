using System;


namespace R5T.T0061
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceCollectionOperator : IServiceCollectionOperator
    {
        #region Static
        
        public static ServiceCollectionOperator Instance { get; } = new();

        #endregion
    }
}