using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record ResponseResult {
		[JsonPropertyName("text")]
		public String StatusText { get; set; }
		[JsonPropertyName("kod")]
		public Int32 StatusCode { get; set; }
	}
}
