// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CapabilitiesOperations.
    /// </summary>
    public static partial class CapabilitiesOperationsExtensions
    {
            /// <summary>
            /// Gets the subscription capabilities available for the specified location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The location name whose capabilities are retrieved.
            /// </param>
            /// <param name='include'>
            /// If specified, restricts the response to only include the selected item.
            /// Possible values include: 'supportedEditions',
            /// 'supportedElasticPoolEditions', 'supportedManagedInstanceVersions',
            /// 'supportedInstancePoolEditions', 'supportedManagedInstanceEditions'
            /// </param>
            public static LocationCapabilities ListByLocation(this ICapabilitiesOperations operations, string locationName, string include = default(string))
            {
                return operations.ListByLocationAsync(locationName, include).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the subscription capabilities available for the specified location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The location name whose capabilities are retrieved.
            /// </param>
            /// <param name='include'>
            /// If specified, restricts the response to only include the selected item.
            /// Possible values include: 'supportedEditions',
            /// 'supportedElasticPoolEditions', 'supportedManagedInstanceVersions',
            /// 'supportedInstancePoolEditions', 'supportedManagedInstanceEditions'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationCapabilities> ListByLocationAsync(this ICapabilitiesOperations operations, string locationName, string include = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationWithHttpMessagesAsync(locationName, include, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
