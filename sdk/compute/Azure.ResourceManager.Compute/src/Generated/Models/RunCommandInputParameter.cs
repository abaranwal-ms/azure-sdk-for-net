// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a run command parameter. </summary>
    public partial class RunCommandInputParameter
    {
        /// <summary> Initializes a new instance of RunCommandInputParameter. </summary>
        /// <param name="name"> The run command parameter name. </param>
        /// <param name="value"> The run command parameter value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public RunCommandInputParameter(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> The run command parameter name. </summary>
        public string Name { get; set; }
        /// <summary> The run command parameter value. </summary>
        public string Value { get; set; }
    }
}
