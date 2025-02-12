// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ImagesResponse
    {
        internal static ImagesResponse DeserializeImagesResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset created = default;
            IReadOnlyList<Image> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<Image> array = new List<Image>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Image.DeserializeImage(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new ImagesResponse(created, data);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="result"> The result to deserialize the model from. </param>
        internal static ImagesResponse FromResponse(PipelineResponse result)
        {
            using var document = JsonDocument.Parse(result.Content);
            return DeserializeImagesResponse(document.RootElement);
        }
    }
}
