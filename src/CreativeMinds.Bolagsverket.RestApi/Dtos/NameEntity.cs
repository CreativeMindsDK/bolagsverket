using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record NameEntity {
		[JsonPropertyName("namn")]
		public String Name { get; set; }
	}
}
