// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SparkStatementOutput
    {
        /// <summary>
        /// Initializes a new instance of the SparkStatementOutput class.
        /// </summary>
        public SparkStatementOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkStatementOutput class.
        /// </summary>
        public SparkStatementOutput(string status = default(string), int? executionCount = default(int?), object data = default(object))
        {
            Status = status;
            ExecutionCount = executionCount;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "execution_count")]
        public int? ExecutionCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

    }
}
