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
using Azure.Management.DataBox.Models;

namespace Azure.Management.DataBox
{
    /// <summary> The Service service client. </summary>
    public partial class ServiceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ServiceOperations for mocking. </summary>
        protected ServiceOperations()
        {
        }
        /// <summary> Initializes a new instance of ServiceOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ServiceOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-04-01")
        {
            RestClient = new ServiceRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> This API provides configuration details specific to given region/location at Subscription level. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="regionConfigurationRequest"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegionConfigurationResponse>> RegionConfigurationAsync(string location, RegionConfigurationRequest regionConfigurationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.RegionConfiguration");
            scope.Start();
            try
            {
                return await RestClient.RegionConfigurationAsync(location, regionConfigurationRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This API provides configuration details specific to given region/location at Subscription level. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="regionConfigurationRequest"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegionConfigurationResponse> RegionConfiguration(string location, RegionConfigurationRequest regionConfigurationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.RegionConfiguration");
            scope.Start();
            try
            {
                return RestClient.RegionConfiguration(location, regionConfigurationRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validateAddress"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AddressValidationOutput>> ValidateAddressAsync(string location, ValidateAddress validateAddress, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateAddress");
            scope.Start();
            try
            {
                return await RestClient.ValidateAddressAsync(location, validateAddress, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validateAddress"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AddressValidationOutput> ValidateAddress(string location, ValidateAddress validateAddress, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateAddress");
            scope.Start();
            try
            {
                return RestClient.ValidateAddress(location, validateAddress, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under subscription. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validationRequest"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ValidationResponse>> ValidateInputsAsync(string location, ValidationRequest validationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateInputs");
            scope.Start();
            try
            {
                return await RestClient.ValidateInputsAsync(location, validationRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under subscription. </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validationRequest"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ValidationResponse> ValidateInputs(string location, ValidationRequest validationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateInputs");
            scope.Start();
            try
            {
                return RestClient.ValidateInputs(location, validationRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This API provides configuration details specific to given region/location at Resource group level. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="regionConfigurationRequest"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegionConfigurationResponse>> RegionConfigurationByResourceGroupAsync(string resourceGroupName, string location, RegionConfigurationRequest regionConfigurationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.RegionConfigurationByResourceGroup");
            scope.Start();
            try
            {
                return await RestClient.RegionConfigurationByResourceGroupAsync(resourceGroupName, location, regionConfigurationRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This API provides configuration details specific to given region/location at Resource group level. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="regionConfigurationRequest"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegionConfigurationResponse> RegionConfigurationByResourceGroup(string resourceGroupName, string location, RegionConfigurationRequest regionConfigurationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.RegionConfigurationByResourceGroup");
            scope.Start();
            try
            {
                return RestClient.RegionConfigurationByResourceGroup(resourceGroupName, location, regionConfigurationRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under resource group. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validationRequest"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ValidationResponse>> ValidateInputsByResourceGroupAsync(string resourceGroupName, string location, ValidationRequest validationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateInputsByResourceGroup");
            scope.Start();
            try
            {
                return await RestClient.ValidateInputsByResourceGroupAsync(resourceGroupName, location, validationRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under resource group. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="validationRequest"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ValidationResponse> ValidateInputsByResourceGroup(string resourceGroupName, string location, ValidationRequest validationRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ValidateInputsByResourceGroup");
            scope.Start();
            try
            {
                return RestClient.ValidateInputsByResourceGroup(resourceGroupName, location, validationRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="availableSkuRequest"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SkuInformation> ListAvailableSkusByResourceGroupAsync(string resourceGroupName, string location, AvailableSkuRequest availableSkuRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (availableSkuRequest == null)
            {
                throw new ArgumentNullException(nameof(availableSkuRequest));
            }

            async Task<Page<SkuInformation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ListAvailableSkusByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAvailableSkusByResourceGroupAsync(resourceGroupName, location, availableSkuRequest, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SkuInformation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ListAvailableSkusByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAvailableSkusByResourceGroupNextPageAsync(nextLink, resourceGroupName, location, availableSkuRequest, cancellationToken).ConfigureAwait(false);
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

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="availableSkuRequest"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SkuInformation> ListAvailableSkusByResourceGroup(string resourceGroupName, string location, AvailableSkuRequest availableSkuRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (availableSkuRequest == null)
            {
                throw new ArgumentNullException(nameof(availableSkuRequest));
            }

            Page<SkuInformation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ListAvailableSkusByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListAvailableSkusByResourceGroup(resourceGroupName, location, availableSkuRequest, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SkuInformation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceOperations.ListAvailableSkusByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListAvailableSkusByResourceGroupNextPage(nextLink, resourceGroupName, location, availableSkuRequest, cancellationToken);
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
    }
}
