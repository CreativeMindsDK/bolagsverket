using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record AddressEntity {
		[JsonPropertyName("co")]
		public String? CoAddress { get; set; }
		[JsonPropertyName("postadress")]
		public String? Address { get; set; }
		[JsonPropertyName("postnummer")]
		public String? PostalCode { get; set; }
		[JsonPropertyName("postort")]
		public String? PostalArea { get; set; }
		[JsonPropertyName("land")]
		public String? Country { get; set; }
		[JsonPropertyName("landEng")]
		public String? CountryEnglish { get; set; }
		[JsonPropertyName("landKod")]
		public String? CountryCode { get; set; }
		[JsonPropertyName("webbadress")]
		public String? WebsiteUrl { get; set; }
		[JsonPropertyName("telefon")]
		public String? PhoneNumber { get; set; }
		[JsonPropertyName("epost")]
		public String? EmailAddress { get; set; }
	}
}
