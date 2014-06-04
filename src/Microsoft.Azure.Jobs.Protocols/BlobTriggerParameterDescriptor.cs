﻿using System.IO;

#if PUBLICPROTOCOL
namespace Microsoft.Azure.Jobs.Protocols
#else
namespace Microsoft.Azure.Jobs.Host.Protocols
#endif
{
    /// <summary>Represents a parameter triggered on a blob in Azure Storage.</summary>
    [JsonTypeName("BlobTrigger")]
#if PUBLICPROTOCOL
    public class BlobTriggerParameterDescriptor : ParameterDescriptor
#else
    internal class BlobTriggerParameterDescriptor : ParameterDescriptor
#endif
    {
        /// <summary>Gets or sets the name of the container.</summary>
        public string ContainerName { get; set; }

        /// <summary>Gets or sets the name of the blob.</summary>
        public string BlobName { get; set; }

        /// <summary>Gets or sets the kind of access the parameter has to the blob.</summary>
        public FileAccess Access { get; set; }
    }
}