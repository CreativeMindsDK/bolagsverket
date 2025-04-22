using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreativeMinds.Bolagsverket.RestApi.Dtos {

	public record DetailRequestResponse {
		[JsonPropertyName("foretag")]
		public CompanyWithAddressEntity Data { get; set; }
		[JsonPropertyName("svarsInformation")]
		public ResponseResult Result { get; set; }
	}
}
