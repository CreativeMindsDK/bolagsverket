using CreativeMinds.Bolagsverket.RestApi.Dtos;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CreativeMinds.Bolagsverket.RestApi {

	public class BolagsverketSearchEngine : IBolagsverketSearchEngine {
		private readonly IHttpClientFactory httpClientFactory;

		public BolagsverketSearchEngine(IHttpClientFactory httpClientFactory) {
			this.httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
		}

		public async Task<CompanySearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			HttpClient client = this.httpClientFactory.CreateClient();

			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri("https://foretagsinfo.bolagsverket.se");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/api/public/foretag/sok?sokord={HttpUtility.UrlEncode(query)}");

				HttpResponseMessage response = await client.SendAsync(request);

				return await response.Content.ReadFromJsonAsync<CompanySearchResponse>(cancellationToken);
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public async Task<DetailRequestResponse> SearchForDetailByIdAsync(String organisationId, CancellationToken cancellationToken) {
			HttpClient client = this.httpClientFactory.CreateClient();

			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri("https://foretagsinfo.bolagsverket.se");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/api/public/foretag/detaljerad/{HttpUtility.UrlEncode(organisationId)}");

				HttpResponseMessage response = await client.SendAsync(request);

				return await response.Content.ReadFromJsonAsync<DetailRequestResponse>(cancellationToken);
			}
			catch (Exception ex) {
				throw ex;
			}
		}
	}
}
