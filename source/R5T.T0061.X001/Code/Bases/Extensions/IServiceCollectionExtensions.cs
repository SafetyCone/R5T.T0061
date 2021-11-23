using System;

using System.Threading.Tasks;

using IServiceCollection = R5T.T0061.IServiceCollection;

using MicrosoftServiceCollection = Microsoft.Extensions.DependencyInjection.ServiceCollection;


namespace System
{
    public static class IServiceCollectionExtensions
    {
        public static Task<MicrosoftServiceCollection> NewAsync(this IServiceCollection _)
        {
            var output = new MicrosoftServiceCollection();

            return Task.FromResult(output);
        }

        public static MicrosoftServiceCollection New(this IServiceCollection _)
        {
            var output = new MicrosoftServiceCollection();
            return output;
        }
    }
}