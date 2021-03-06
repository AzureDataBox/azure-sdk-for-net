﻿// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>


namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class TypeConversionSettings
    {
        /// <summary>
        /// Initializes a new instance of the TypeConversionSettings class.
        /// </summary>
        public TypeConversionSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypeConversionSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the message are deserialized this collection</param>
        /// <param name="allowDataTruncation">Whether to allow data truncation when converting the data. Type: boolean (or Expression with resultType boolean).</param>
        /// <param name="treatBooleanAsNumber">Whether to treat boolean values as numbers. Type: boolean (or Expression with resultType boolean).</param>
        /// <param name="dateTimeFormat">The format for DateTime values. Type: string (or Expression with resultType string).</param>
        /// <param name="dateTimeOffsetFormat">The format for DateTimeOffset values. Type: string (or Expression with resultType string).</param>
        /// <param name="timeSpanFormat">The format for TimeSpan values. Type: string (or Expression with resultType string).</param>
        /// <param name="culture">The culture used to convert data from/to string. Type: string (or Expression with resultType string).</param>
        public TypeConversionSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object allowDataTruncation = default(object), object treatBooleanAsNumber = default(object), object dateTimeFormat = default(object), object dateTimeOffsetFormat = default(object), object timeSpanFormat = default(object), object culture = default(object))
        {
            AdditionalProperties = additionalProperties;
            AllowDataTruncation = AllowDataTruncation;
            TreatBooleanAsNumber = treatBooleanAsNumber;
            DateTimeFormat = dateTimeFormat;
            DateTimeOffsetFormat = dateTimeOffsetFormat;
            TimeSpanFormat = timeSpanFormat;
            Culture = culture;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets allowDataTruncation indicating whether to allow data truncation when converting the data. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "allowDataTruncation")]
        public object AllowDataTruncation { get; set; }

        /// <summary>
        /// Gets or sets treatBooleanAsNumber indicating whether to treat boolean values as numbers. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "treatBooleanAsNumber")]
        public object TreatBooleanAsNumber { get; set; }

        /// <summary>
        /// Gets or sets the format for DateTime values. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeFormat")]
        public object DateTimeFormat { get; set; }

        /// <summary>
        /// Gets or sets the format for DateTimeOffset values. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeOffsetFormat")]
        public object DateTimeOffsetFormat { get; set; }

        /// <summary>
        /// Gets or sets the format for TimeSpan values. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "timeSpanFormat")]
        public object TimeSpanFormat { get; set; }

        /// <summary>
        /// Gets or sets the culture used to convert data from/to string. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "culture")]
        public object Culture { get; set; }
    }
}
