using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using IServiceProviderExtensionMethodBase = R5T.T0061.IServiceProvider;
using MicrosoftServiceProvider = Microsoft.Extensions.DependencyInjection.ServiceProvider;

using Instances = R5T.T0061.X001.Instances;


namespace System
{
    public static class IServiceProviderExtensions
    {
        public static Task<MicrosoftServiceProvider> NewAsync(this IServiceProviderExtensionMethodBase _)
        {
            var output = Instances.ServiceCollection.New()
                .BuildServiceProvider();

            return Task.FromResult(output);
        }

        public static MicrosoftServiceProvider New(this IServiceProviderExtensionMethodBase _)
        {
            var output = Instances.ServiceCollection.New()
                .BuildServiceProvider();

            return output;
        }
    }
}
