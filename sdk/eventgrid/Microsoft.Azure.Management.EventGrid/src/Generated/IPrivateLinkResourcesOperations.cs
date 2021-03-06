// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateLinkResourcesOperations operations.
    /// </summary>
    public partial interface IPrivateLinkResourcesOperations
    {
        /// <summary>
        /// Get a private link resource.
        /// </summary>
        /// <remarks>
        /// Get properties of a private link resource.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='parentType'>
        /// The type of the parent resource. This can be either \'topics\',
        /// \'domains\', or \'partnerNamespaces\'.
        /// </param>
        /// <param name='parentName'>
        /// The name of the parent resource (namely, either, the topic name,
        /// domain name, or partner namespace name).
        /// </param>
        /// <param name='privateLinkResourceName'>
        /// The name of private link resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateLinkResource>> GetWithHttpMessagesAsync(string resourceGroupName, string parentType, string parentName, string privateLinkResourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List private link resources under specific topic, domain, or
        /// partner namespace.
        /// </summary>
        /// <remarks>
        /// List all the private link resources under a topic, domain, or
        /// partner namespace.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='parentType'>
        /// The type of the parent resource. This can be either \'topics\',
        /// \'domains\', or \'partnerNamespaces\'.
        /// </param>
        /// <param name='parentName'>
        /// The name of the parent resource (namely, either, the topic name,
        /// domain name, or partner namespace name).
        /// </param>
        /// <param name='filter'>
        /// The query used to filter the search results using OData syntax.
        /// Filtering is permitted on the 'name' property only and with limited
        /// number of OData operations. These operations are: the 'contains'
        /// function as well as the following logical operations: not, and, or,
        /// eq (for equal), and ne (for not equal). No arithmetic operations
        /// are supported. The following is a valid filter example:
        /// $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The
        /// following is not a valid filter example: $filter=location eq
        /// 'westus'.
        /// </param>
        /// <param name='top'>
        /// The number of results to return per page for the list operation.
        /// Valid range for top parameter is 1 to 100. If not specified, the
        /// default number of results to be returned is 20 items per page.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateLinkResource>>> ListByResourceWithHttpMessagesAsync(string resourceGroupName, string parentType, string parentName, string filter = default(string), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List private link resources under specific topic, domain, or
        /// partner namespace.
        /// </summary>
        /// <remarks>
        /// List all the private link resources under a topic, domain, or
        /// partner namespace.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateLinkResource>>> ListByResourceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
