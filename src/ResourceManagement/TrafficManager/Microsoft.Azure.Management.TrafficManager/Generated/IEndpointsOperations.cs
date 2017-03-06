// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// EndpointsOperations operations.
    /// </summary>
    public partial interface IEndpointsOperations
    {
        /// <summary>
        /// Update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be updated.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be updated.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be updated.
        /// </param>
        /// <param name='parameters'>
        /// The Traffic Manager endpoint parameters supplied to the Update
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Endpoint>> UpdateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Endpoint>> GetWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be created or updated.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be created or updated.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// The Traffic Manager endpoint parameters supplied to the
        /// CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Endpoint>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Traffic Manager endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Traffic Manager
        /// endpoint to be deleted.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='endpointType'>
        /// The type of the Traffic Manager endpoint to be deleted.
        /// </param>
        /// <param name='endpointName'>
        /// The name of the Traffic Manager endpoint to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string profileName, string endpointType, string endpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
