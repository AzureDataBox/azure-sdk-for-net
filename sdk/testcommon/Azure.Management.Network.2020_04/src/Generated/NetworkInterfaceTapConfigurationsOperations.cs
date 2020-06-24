// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The NetworkInterfaceTapConfigurations service client. </summary>
    public partial class NetworkInterfaceTapConfigurationsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkInterfaceTapConfigurationsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of NetworkInterfaceTapConfigurationsOperations for mocking. </summary>
        protected NetworkInterfaceTapConfigurationsOperations()
        {
        }
        /// <summary> Initializes a new instance of NetworkInterfaceTapConfigurationsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal NetworkInterfaceTapConfigurationsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new NetworkInterfaceTapConfigurationsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkInterfaceTapConfiguration>> GetAsync(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterfaceTapConfiguration> Get(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkInterfaceName, tapConfigurationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkInterfaceTapConfiguration> ListAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            async Task<Page<NetworkInterfaceTapConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceTapConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkInterfaceTapConfiguration> List(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            Page<NetworkInterfaceTapConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkInterfaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceTapConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, networkInterfaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified tap configuration from the NetworkInterface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NetworkInterfaceTapConfigurationsDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, cancellationToken).ConfigureAwait(false);
                return new NetworkInterfaceTapConfigurationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkInterfaceName, tapConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified tap configuration from the NetworkInterface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkInterfaceTapConfigurationsDeleteOperation StartDelete(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkInterfaceName, tapConfigurationName, cancellationToken);
                return new NetworkInterfaceTapConfigurationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkInterfaceName, tapConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NetworkInterfaceTapConfigurationsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters, cancellationToken).ConfigureAwait(false);
                return new NetworkInterfaceTapConfigurationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkInterfaceTapConfigurationsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters, cancellationToken);
                return new NetworkInterfaceTapConfigurationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
