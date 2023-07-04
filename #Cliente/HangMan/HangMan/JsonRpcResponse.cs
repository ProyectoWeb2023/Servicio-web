using Newtonsoft.Json;

namespace HangMan
{
    public class JsonRpcResponse<T>
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("error")]
        public JsonRpcError Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}