// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network profile resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkProfile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        public NetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="containerNetworkInterfaces">List of child container
        /// network interfaces.</param>
        /// <param name="containerNetworkInterfaceConfigurations">List of chid
        /// container network interface configurations.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// network profile resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// network profile resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public NetworkProfile(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<ContainerNetworkInterface> containerNetworkInterfaces = default(IList<ContainerNetworkInterface>), IList<ContainerNetworkInterfaceConfiguration> containerNetworkInterfaceConfigurations = default(IList<ContainerNetworkInterfaceConfiguration>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            ContainerNetworkInterfaces = containerNetworkInterfaces;
            ContainerNetworkInterfaceConfigurations = containerNetworkInterfaceConfigurations;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of child container network interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerNetworkInterfaces")]
        public IList<ContainerNetworkInterface> ContainerNetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets or sets list of chid container network interface
        /// configurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerNetworkInterfaceConfigurations")]
        public IList<ContainerNetworkInterfaceConfiguration> ContainerNetworkInterfaceConfigurations { get; set; }

        /// <summary>
        /// Gets the resource GUID property of the network profile resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the network profile resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
