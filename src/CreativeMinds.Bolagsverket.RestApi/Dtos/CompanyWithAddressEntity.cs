using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record CompanyWithAddressEntity {
		[JsonPropertyName("organisationsnummer")]
		public String OrganisationId { get; set; }
		[JsonPropertyName("namn")]
		public String Name { get; set; }
		[JsonPropertyName("status")]
		public CompanyStatus[] Status { get; set; }
		[JsonPropertyName("adress")]
		public AddressEntity Address { get; set; }
		[JsonPropertyName("sate")]
		public String? Area { get; set; }
		[JsonPropertyName("foretagsform")]
		public String CompanyType { get; set; }
		[JsonPropertyName("foretagsformKod")]
		public String CompanyTypeCode { get; set; }
		[JsonPropertyName("registreringsdatum")]
		public DateTime? RegistrationDate { get; set; }
		[JsonPropertyName("sarskiltForetagsnamn")]
		public NameEntity[] OtherCompanyName { get; set; }
		[JsonPropertyName("foretagsnamnPaFrammandeSprak")]
		public NameEntity[] CompanyNameInOtherLanguages { get; set; }
		[JsonPropertyName("avslutat")]
		public Boolean Closed { get; set; }
		[JsonPropertyName("lopnummer")]
		public Int32? SomeNumber { get; set; }
		[JsonPropertyName("antalArenden")]
		public Int32? Cases { get; set; }
		[JsonPropertyName("likvidationsforelaggandeMeddelande")]
		public Object? What { get; set; }
		[JsonPropertyName("svarsdatum")]
		public String? AnotherDate { get; set; }
	}
}
