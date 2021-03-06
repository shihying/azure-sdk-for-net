// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents whether or not a web app is cloneable
    /// </summary>
    public partial class SiteCloneability
    {
        /// <summary>
        /// Initializes a new instance of the SiteCloneability class.
        /// </summary>
        public SiteCloneability() { }

        /// <summary>
        /// Initializes a new instance of the SiteCloneability class.
        /// </summary>
        public SiteCloneability(CloneAbilityResult result, IList<SiteCloneabilityCriterion> blockingFeatures = default(IList<SiteCloneabilityCriterion>), IList<SiteCloneabilityCriterion> unsupportedFeatures = default(IList<SiteCloneabilityCriterion>), IList<SiteCloneabilityCriterion> blockingCharacteristics = default(IList<SiteCloneabilityCriterion>))
        {
            Result = result;
            BlockingFeatures = blockingFeatures;
            UnsupportedFeatures = unsupportedFeatures;
            BlockingCharacteristics = blockingCharacteristics;
        }

        /// <summary>
        /// Name of web app. Possible values include: 'Cloneable',
        /// 'PartiallyCloneable', 'NotCloneable'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public CloneAbilityResult Result { get; set; }

        /// <summary>
        /// List of features enabled on web app that prevent cloning
        /// </summary>
        [JsonProperty(PropertyName = "blockingFeatures")]
        public IList<SiteCloneabilityCriterion> BlockingFeatures { get; set; }

        /// <summary>
        /// List of features enabled on web app that are non-blocking but
        /// cannot be cloned. The web app can still be cloned
        /// but the features in this list will not be set up on
        /// cloned web app.
        /// </summary>
        [JsonProperty(PropertyName = "unsupportedFeatures")]
        public IList<SiteCloneabilityCriterion> UnsupportedFeatures { get; set; }

        /// <summary>
        /// List of blocking application characteristics
        /// </summary>
        [JsonProperty(PropertyName = "blockingCharacteristics")]
        public IList<SiteCloneabilityCriterion> BlockingCharacteristics { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
