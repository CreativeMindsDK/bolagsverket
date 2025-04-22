using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CreativeMinds.Bolagsverket.RestApi {

	public static class ServiceCollectionExtensions {

		public static IServiceCollection AddBolagsverketSearch(this IServiceCollection services, IConfiguration configuration) {
			services.AddSingleton<IBolagsverketSearchEngine, BolagsverketSearchEngine>();

			return services;
		}
	}
}
