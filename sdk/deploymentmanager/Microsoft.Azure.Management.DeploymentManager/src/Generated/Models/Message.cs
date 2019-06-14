// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Supplementary contextual messages during a rollout.
    /// </summary>
    public partial class Message
    {
        /// <summary>
        /// Initializes a new instance of the Message class.
        /// </summary>
        public Message()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Message class.
        /// </summary>
        /// <param name="timeStamp">Time in UTC this message was
        /// provided.</param>
        /// <param name="messageProperty">The actual message text.</param>
        public Message(System.DateTime? timeStamp = default(System.DateTime?), string messageProperty = default(string))
        {
            TimeStamp = timeStamp;
            MessageProperty = messageProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets time in UTC this message was provided.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTime? TimeStamp { get; private set; }

        /// <summary>
        /// Gets the actual message text.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string MessageProperty { get; private set; }

    }
}