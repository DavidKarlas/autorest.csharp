// <auto-generated/>

#nullable disable

using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEmbeddingRequest : IUtf8JsonWriteable
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
            writer.WritePropertyName("input"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Input);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Input.ToString()).RootElement);
#endif
            if (OptionalProperty.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
