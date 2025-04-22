using CreativeMinds.Bolagsverket.RestApi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp {

	internal class Program {

		static async Task<Int32> Main(String[] args) {
			var serviceProvider = new ServiceCollection()
						.AddSingleton<IBolagsverketSearchEngine, BolagsverketSearchEngine>()
						.AddHttpClient()
						.BuildServiceProvider();

			CancellationToken cancellationToken = new CancellationToken();

			var searchEngine = serviceProvider.GetService<IBolagsverketSearchEngine>();

			var result = await searchEngine.SearchForCompanyByNameAsync("bae", 100, cancellationToken);

			foreach (var company in result.Hits) {
				var result2 = await searchEngine.SearchForDetailByIdAsync(company.OrganisationId, cancellationToken);
			}

			return 0;
		}
	}
}
