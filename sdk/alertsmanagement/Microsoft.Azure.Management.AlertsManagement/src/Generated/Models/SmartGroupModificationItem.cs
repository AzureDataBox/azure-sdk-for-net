// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// smartGroup modification item.
    /// </summary>
    public partial class SmartGroupModificationItem
    {
        /// <summary>
        /// Initializes a new instance of the SmartGroupModificationItem class.
        /// </summary>
        public SmartGroupModificationItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmartGroupModificationItem class.
        /// </summary>
        /// <param name="modificationEvent">Reason for the modification.
        /// Possible values include: 'SmartGroupCreated', 'StateChange',
        /// 'AlertAdded', 'AlertRemoved'</param>
        /// <param name="oldValue">Old value</param>
        /// <param name="newValue">New value</param>
        /// <param name="modifiedAt">Modified date and time</param>
        /// <param name="modifiedBy">Modified user details (Principal client
        /// name)</param>
        /// <param name="comments">Modification comments</param>
        /// <param name="description">Description of the modification</param>
        public SmartGroupModificationItem(SmartGroupModificationEvent? modificationEvent = default(SmartGroupModificationEvent?), string oldValue = default(string), string newValue = default(string), string modifiedAt = default(string), string modifiedBy = default(string), string comments = default(string), string description = default(string))
        {
            ModificationEvent = modificationEvent;
            OldValue = oldValue;
            NewValue = newValue;
            ModifiedAt = modifiedAt;
            ModifiedBy = modifiedBy;
            Comments = comments;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reason for the modification. Possible values include:
        /// 'SmartGroupCreated', 'StateChange', 'AlertAdded', 'AlertRemoved'
        /// </summary>
        [JsonProperty(PropertyName = "modificationEvent")]
        public SmartGroupModificationEvent? ModificationEvent { get; set; }

        /// <summary>
        /// Gets or sets old value
        /// </summary>
        [JsonProperty(PropertyName = "oldValue")]
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or sets new value
        /// </summary>
        [JsonProperty(PropertyName = "newValue")]
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets modified date and time
        /// </summary>
        [JsonProperty(PropertyName = "modifiedAt")]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets modified user details (Principal client name)
        /// </summary>
        [JsonProperty(PropertyName = "modifiedBy")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets modification comments
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets description of the modification
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
