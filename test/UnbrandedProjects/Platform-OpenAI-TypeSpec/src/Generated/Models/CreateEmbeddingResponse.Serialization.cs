// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEmbeddingResponse
    {
        internal static CreateEmbeddingResponse DeserializeCreateEmbeddingResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CreateEmbeddingResponseObject @object = default;
            string model = default;
            IReadOnlyList<Embedding> data = default;
            CreateUsage usage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = new CreateEmbeddingResponseObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<Embedding> array = new List<Embedding>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Embedding.DeserializeEmbedding(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    usage = CreateUsage.DeserializeCreateUsage(property.Value);
                    continue;
                }
            }
            return new CreateEmbeddingResponse(@object, model, data, usage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static CreateEmbeddingResponse FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeCreateEmbeddingResponse(document.RootElement);
        }
    }
}
