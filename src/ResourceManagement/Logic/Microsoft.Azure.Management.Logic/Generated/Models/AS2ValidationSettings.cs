// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class AS2ValidationSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2ValidationSettings class.
        /// </summary>
        public AS2ValidationSettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2ValidationSettings class.
        /// </summary>
        public AS2ValidationSettings(bool? overrideMessageProperties = default(bool?), bool? encryptMessage = default(bool?), bool? signMessage = default(bool?), bool? compressMessage = default(bool?), bool? checkDuplicateMessage = default(bool?), int? interchangeDuplicatesValidityDays = default(int?), bool? checkCertificateRevocationListOnSend = default(bool?), bool? checkCertificateRevocationListOnReceive = default(bool?), EncryptionAlgorithm? encryptionAlgorithm = default(EncryptionAlgorithm?))
        {
            OverrideMessageProperties = overrideMessageProperties;
            EncryptMessage = encryptMessage;
            SignMessage = signMessage;
            CompressMessage = compressMessage;
            CheckDuplicateMessage = checkDuplicateMessage;
            InterchangeDuplicatesValidityDays = interchangeDuplicatesValidityDays;
            CheckCertificateRevocationListOnSend = checkCertificateRevocationListOnSend;
            CheckCertificateRevocationListOnReceive = checkCertificateRevocationListOnReceive;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to override incoming
        /// message properties with those in agreement.
        /// </summary>
        [JsonProperty(PropertyName = "overrideMessageProperties")]
        public bool? OverrideMessageProperties { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// encrypted.
        /// </summary>
        [JsonProperty(PropertyName = "encryptMessage")]
        public bool? EncryptMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// signed.
        /// </summary>
        [JsonProperty(PropertyName = "signMessage")]
        public bool? SignMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// compressed.
        /// </summary>
        [JsonProperty(PropertyName = "compressMessage")]
        public bool? CompressMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateMessage")]
        public bool? CheckDuplicateMessage { get; set; }

        /// <summary>
        /// Gets or sets the number of days to look back for duplicate
        /// interchange.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeDuplicatesValidityDays")]
        public int? InterchangeDuplicatesValidityDays { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for certificate
        /// revocation list on send.
        /// </summary>
        [JsonProperty(PropertyName = "checkCertificateRevocationListOnSend")]
        public bool? CheckCertificateRevocationListOnSend { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for certificate
        /// revocation list on receive.
        /// </summary>
        [JsonProperty(PropertyName = "checkCertificateRevocationListOnReceive")]
        public bool? CheckCertificateRevocationListOnReceive { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm. Possible values include:
        /// 'NotSpecified', 'None', 'DES3', 'RC2', 'AES128', 'AES192',
        /// 'AES256'
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public EncryptionAlgorithm? EncryptionAlgorithm { get; set; }

    }
}
