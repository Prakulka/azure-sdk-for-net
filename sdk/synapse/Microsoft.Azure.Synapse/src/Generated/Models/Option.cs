// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Option
    {
        /// <summary>
        /// Initializes a new instance of the Option class.
        /// </summary>
        public Option()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Option class.
        /// </summary>
        public Option(string additionalProp1 = default(string), string additionalProp2 = default(string), string additionalProp3 = default(string))
        {
            AdditionalProp1 = additionalProp1;
            AdditionalProp2 = additionalProp2;
            AdditionalProp3 = additionalProp3;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalProp1")]
        public string AdditionalProp1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalProp2")]
        public string AdditionalProp2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalProp3")]
        public string AdditionalProp3 { get; set; }

    }
}