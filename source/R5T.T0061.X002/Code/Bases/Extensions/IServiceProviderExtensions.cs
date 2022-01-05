using System;

using R5T.T0079;


namespace System
{
    public static class IServiceProviderExtensions
    {
        public static IServiceProviderBuilder NewBuilder(this R5T.T0061.IServiceProvider _)
        {
            var output = new ServiceProviderBuilder();
            return output;
        }
    }
}