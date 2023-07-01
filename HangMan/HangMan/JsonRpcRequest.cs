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

        public JsonRpcRequest(string method, object parameters)
        {
            this.JsonRpc = "2.0";
            this.Method = method;
            this.Params = parameters;
            this.Id = Guid.NewGuid().ToString();
        }
        public JsonRpcRequest(string method)
        {
            this.JsonRpc = "2.0";
            this.Method = method;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}