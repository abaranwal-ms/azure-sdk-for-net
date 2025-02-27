// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleOverride
    {
        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public ManagedRuleOverride(string ruleId)
        {
            Argument.AssertNotNull(ruleId, nameof(ruleId));

            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="state"> The state of the managed rule. Defaults to Disabled if not specified. </param>
        /// <param name="action"> Describes the override action to be applied when rule matches. </param>
        internal ManagedRuleOverride(string ruleId, ManagedRuleEnabledState? state, RuleMatchActionType? action)
        {
            RuleId = ruleId;
            State = state;
            Action = action;
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; set; }
        /// <summary> The state of the managed rule. Defaults to Disabled if not specified. </summary>
        public ManagedRuleEnabledState? State { get; set; }
        /// <summary> Describes the override action to be applied when rule matches. </summary>
        public RuleMatchActionType? Action { get; set; }
    }
}
