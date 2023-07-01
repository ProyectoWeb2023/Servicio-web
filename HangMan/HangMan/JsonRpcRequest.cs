using Newtonsoft.Json;
using System;

namespace HangMan
{
    public class JsonRpcRequest
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public object Params { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public JsonRpcRequest(string method, object parameters = null)
        {
            this.JsonRpc = "2.0";
            this.Method = method;
            this.Params = parameters ?? new { param = "null" };
            this.Id = Guid.NewGuid().ToString();
        }
    }
}