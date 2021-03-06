using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MercadoPago.DotNet
{
    internal class Response<T>
    {
        [JsonProperty(PropertyName = "status")]
        public HttpStatusCode Status { get; private set; }

        [JsonProperty(PropertyName = "response")]
        public T Payload { get; private set; }

        [JsonIgnore]
        public string RawData { get; private set; }

        public Response(HttpStatusCode status, T payload, string rawData)
        {
            this.Status = status;
            this.Payload = payload;
            this.RawData = rawData;
        }
    }
}