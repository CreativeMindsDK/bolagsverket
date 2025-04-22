using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record CompanyLightEntity {
		[JsonPropertyName("organisationsnummer")]
		public String OrganisationId { get; set; }
		[JsonPropertyName("namn")]
		public String Name { get; set; }
		[JsonPropertyName("status")]
		public CompanyStatus[] Status { get; set; }
		[JsonPropertyName("ort")]
		public String Ort { get; set; }
		[JsonPropertyName("avslutat")]
		public Boolean Closed { get; set; }
		[JsonPropertyName("lopnummer")]
		public Int32? SomeNumber { get; set; }
		[JsonPropertyName("foretagsformKod")]
		public String CompanyTypeCode { get; set; }
	}
}
