// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The GremlinDatabaseGetPropertiesOptions. </summary>
    public partial class GremlinDatabaseGetPropertiesOptions : OptionsResource
    {
        /// <summary> Initializes a new instance of GremlinDatabaseGetPropertiesOptions. </summary>
        public GremlinDatabaseGetPropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of GremlinDatabaseGetPropertiesOptions. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal GremlinDatabaseGetPropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
