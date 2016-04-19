// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// The Resource Manager API includes operations for managing recovery
    /// points created by backup operations on the items protected by your
    /// Recovery Services Vault.
    /// </summary>
    public partial interface IRecoveryPointOperations
    {
        /// <summary>
        /// Gets Info for the given recovery point of the given item protected
        /// by your Recovery Services Vault as specified by the recovery point
        /// ID passed in the arguments.This is an asynchronous operation. To
        /// determine whether the backend service has finished processing the
        /// request, call the Get Protected Item Operation Result API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Container Name for the backup item
        /// </param>
        /// <param name='protectedItemName'>
        /// Protected item name for the backup item
        /// </param>
        /// <param name='recoveryPointId'>
        /// Recovery point id for the backup item
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a RecoveryPointResponse object.
        /// </returns>
        Task<RecoveryPointResponse> GetAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, string containerName, string protectedItemName, string recoveryPointId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all the recovery points of the given item protected by your
        /// Recovery Services Vault according to the query filter supplied in
        /// the arguments.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Container Name for the backup item
        /// </param>
        /// <param name='protectedItemName'>
        /// Protected item name for the backup item
        /// </param>
        /// <param name='queryFilter'>
        /// Recovery point id for the backup item
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a RecoveryPointListResponse object.
        /// </returns>
        Task<RecoveryPointListResponse> ListAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, string containerName, string protectedItemName, RecoveryPointQueryParameters queryFilter, CancellationToken cancellationToken);
    }
}
