// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Domain availablility check result.
    /// </summary>
    public partial class DomainAvailablilityCheckResult
    {
        /// <summary>
        /// Initializes a new instance of the DomainAvailablilityCheckResult
        /// class.
        /// </summary>
        public DomainAvailablilityCheckResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainAvailablilityCheckResult
        /// class.
        /// </summary>
        /// <param name="name">Name of the domain.</param>
        /// <param name="available">&lt;code&gt;true&lt;/code&gt; if domain can
        /// be purchased using CreateDomain API; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="domainType">Valid values are Regular domain: Azure
        /// will charge the full price of domain registration, SoftDeleted:
        /// Purchasing this domain will simply restore it and this operation
        /// will not cost anything. Possible values include: 'Regular',
        /// 'SoftDeleted'</param>
        public DomainAvailablilityCheckResult(string name = default(string), bool? available = default(bool?), DomainType? domainType = default(DomainType?))
        {
            Name = name;
            Available = available;
            DomainType = domainType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the domain.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// domain can be purchased using CreateDomain API; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; set; }

        /// <summary>
        /// Gets or sets valid values are Regular domain: Azure will charge the
        /// full price of domain registration, SoftDeleted: Purchasing this
        /// domain will simply restore it and this operation will not cost
        /// anything. Possible values include: 'Regular', 'SoftDeleted'
        /// </summary>
        [JsonProperty(PropertyName = "domainType")]
        public DomainType? DomainType { get; set; }

    }
}
