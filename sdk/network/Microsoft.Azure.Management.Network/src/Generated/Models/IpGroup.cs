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
    /// The IpGroups resource information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IpGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IpGroup class.
        /// </summary>
        public IpGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// IpGroups resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="ipAddresses">IpAddresses/IpAddressPrefixes in the
        /// IpGroups resource.</param>
        /// <param name="firewalls">List of references to Azure resources that
        /// this IpGroups is associated with.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public IpGroup(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), IList<string> ipAddresses = default(IList<string>), IList<SubResource> firewalls = default(IList<SubResource>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            IpAddresses = ipAddresses;
            Firewalls = firewalls;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the IpGroups resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets ipAddresses/IpAddressPrefixes in the IpGroups
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddresses")]
        public IList<string> IpAddresses { get; set; }

        /// <summary>
        /// Gets list of references to Azure resources that this IpGroups is
        /// associated with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewalls")]
        public IList<SubResource> Firewalls { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
