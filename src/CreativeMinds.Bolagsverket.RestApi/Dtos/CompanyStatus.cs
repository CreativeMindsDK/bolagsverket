using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record CompanyStatus {
		[JsonPropertyName("kod")]
		public String Code { get; set; }
		[JsonPropertyName("datum")]
		public DateTime? Date { get; set; }
		[JsonPropertyName("sv")]
		public String SwedishStatusText { get; set; }
		[JsonPropertyName("en")]
		public String EnglishStatusText { get; set; }
	}
}
