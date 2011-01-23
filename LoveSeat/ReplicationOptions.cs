using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoveSeat
{
	public class ReplicationOptions
	{
		[JsonProperty(Constants.SOURCE)]
		public string Source { get; internal set; }
		[JsonProperty(Constants.TARGET)]
		public string Target { get; internal set; }
		[JsonProperty(Constants.CONTINUOUS)]
		public bool? Continuous { get; set; }
		[JsonProperty(Constants.QUERY_PARAMS)]
		public Dictionary<string,string> QueryParams { get; set; }
		[JsonProperty(Constants.CREATE_TARGET)]
		public bool? CreateTarget { get; set; }
		[JsonProperty(Constants.FILTER)]
		public string Filter { get; set; }

		public ReplicationOptions(string source, string target)
		{
			Source = source;
			Target = target;
		}

		public override string ToString()
		{
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.NullValueHandling = NullValueHandling.Ignore;
			return JsonConvert.SerializeObject(this, Formatting.None, settings);
		}
	}
}