using CreativeMinds.Bolagsverket.RestApi.Dtos;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace CreativeMinds.Bolagsverket.RestApi {

	public interface IBolagsverketSearchEngine {
		Task<CompanySearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<DetailRequestResponse> SearchForDetailByIdAsync(String organisationId, CancellationToken cancellationToken);
	}
}
