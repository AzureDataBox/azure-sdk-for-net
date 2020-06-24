// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationPackageOperations.
    /// </summary>
    public static partial class ApplicationPackageOperationsExtensions
    {
            /// <summary>
            /// Activates the specified application package. This should be done after the
            /// `ApplicationPackage` was created and uploaded. This needs to be done before
            /// an `ApplicationPackage` can be used on Pools or Tasks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            /// <param name='format'>
            /// The format of the application package binary file.
            /// </param>
            public static ApplicationPackage Activate(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName, string format)
            {
                return operations.ActivateAsync(resourceGroupName, accountName, applicationName, versionName, format).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activates the specified application package. This should be done after the
            /// `ApplicationPackage` was created and uploaded. This needs to be done before
            /// an `ApplicationPackage` can be used on Pools or Tasks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            /// <param name='format'>
            /// The format of the application package binary file.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationPackage> ActivateAsync(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName, string format, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ActivateWithHttpMessagesAsync(resourceGroupName, accountName, applicationName, versionName, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an application package record. The record contains the SAS where
            /// the package should be uploaded to.  Once it is uploaded the
            /// `ApplicationPackage` needs to be activated using `ApplicationPackageActive`
            /// before it can be used.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            public static ApplicationPackage Create(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName)
            {
                return operations.CreateAsync(resourceGroupName, accountName, applicationName, versionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an application package record. The record contains the SAS where
            /// the package should be uploaded to.  Once it is uploaded the
            /// `ApplicationPackage` needs to be activated using `ApplicationPackageActive`
            /// before it can be used.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationPackage> CreateAsync(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, applicationName, versionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an application package record and its associated binary file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            public static void Delete(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, applicationName, versionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an application package record and its associated binary file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, applicationName, versionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about the specified application package.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            public static ApplicationPackage Get(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName)
            {
                return operations.GetAsync(resourceGroupName, accountName, applicationName, versionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified application package.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='versionName'>
            /// The version of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationPackage> GetAsync(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, string versionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, applicationName, versionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the application packages in the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='maxresults'>
            /// The maximum number of items to return in the response.
            /// </param>
            public static IPage<ApplicationPackage> List(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, int? maxresults = default(int?))
            {
                return operations.ListAsync(resourceGroupName, accountName, applicationName, maxresults).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the application packages in the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application. This must be unique within the account.
            /// </param>
            /// <param name='maxresults'>
            /// The maximum number of items to return in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationPackage>> ListAsync(this IApplicationPackageOperations operations, string resourceGroupName, string accountName, string applicationName, int? maxresults = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, applicationName, maxresults, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the application packages in the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationPackage> ListNext(this IApplicationPackageOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the application packages in the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationPackage>> ListNextAsync(this IApplicationPackageOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
