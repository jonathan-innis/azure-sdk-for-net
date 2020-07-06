// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> Create or update DigitalTwinsInstance endpoint. </summary>
    public partial class DigitalTwinsEndpointCreateOrUpdateOperation : Operation<DigitalTwinsEndpointResource>, IOperationSource<DigitalTwinsEndpointResource>
    {
        private readonly ArmOperationHelpers<DigitalTwinsEndpointResource> _operation;
        internal DigitalTwinsEndpointCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<DigitalTwinsEndpointResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DigitalTwinsEndpointCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DigitalTwinsEndpointResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DigitalTwinsEndpointResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DigitalTwinsEndpointResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DigitalTwinsEndpointResource IOperationSource<DigitalTwinsEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return DigitalTwinsEndpointResource.DeserializeDigitalTwinsEndpointResource(document.RootElement);
            }
        }

        async ValueTask<DigitalTwinsEndpointResource> IOperationSource<DigitalTwinsEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return DigitalTwinsEndpointResource.DeserializeDigitalTwinsEndpointResource(document.RootElement);
            }
        }
    }
}