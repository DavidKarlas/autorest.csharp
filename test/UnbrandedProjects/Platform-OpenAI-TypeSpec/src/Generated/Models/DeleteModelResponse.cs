// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The DeleteModelResponse. </summary>
    public partial class DeleteModelResponse
    {
        /// <summary> Initializes a new instance of DeleteModelResponse. </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="deleted"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="object"/> is null. </exception>
        internal DeleteModelResponse(string id, string @object, bool deleted)
        {
            ClientUtilities.AssertNotNull(id, nameof(id));
            ClientUtilities.AssertNotNull(@object, nameof(@object));

            Id = id;
            Object = @object;
            Deleted = deleted;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the deleted. </summary>
        public bool Deleted { get; }
    }
}
