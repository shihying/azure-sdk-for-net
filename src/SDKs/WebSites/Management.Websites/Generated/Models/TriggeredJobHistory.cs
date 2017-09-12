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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Triggered Web Job History. List of Triggered Web Job Run Information
    /// elements.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TriggeredJobHistory : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the TriggeredJobHistory class.
        /// </summary>
        public TriggeredJobHistory()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggeredJobHistory class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="triggeredJobRuns">List of triggered web job
        /// runs.</param>
        public TriggeredJobHistory(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IList<TriggeredJobRun> triggeredJobRuns = default(IList<TriggeredJobRun>))
            : base(id, name, kind, type)
        {
            TriggeredJobRuns = triggeredJobRuns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of triggered web job runs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.triggeredJobRuns")]
        public IList<TriggeredJobRun> TriggeredJobRuns { get; set; }

    }
}
