using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record CompanySearchResponse {
		[JsonPropertyName("trafflistan")]
		public CompanyLightEntity[] Hits { get; set; }
		[JsonPropertyName("svarsInformation")]
		public ResponseResult Result { get; set; }
	}
}
