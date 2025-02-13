// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using ClientAndOperationGroup;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ClientAndOperationGroupClient"/> to client builder. </summary>
    public static partial class ClientAndOperationGroupClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ClientAndOperationGroupClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        public static IAzureClientBuilder<ClientAndOperationGroupClient, ClientAndOperationGroupClientOptions> AddClientAndOperationGroupClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ClientAndOperationGroupClient, ClientAndOperationGroupClientOptions>((options) => new ClientAndOperationGroupClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="ClientAndOperationGroupClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ClientAndOperationGroupClient, ClientAndOperationGroupClientOptions> AddClientAndOperationGroupClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ClientAndOperationGroupClient, ClientAndOperationGroupClientOptions>(configuration);
        }
    }
}
