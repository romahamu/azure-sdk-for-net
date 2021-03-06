// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An instance failover group. </summary>
    public partial class InstanceFailoverGroup : ProxyResource
    {
        /// <summary> Initializes a new instance of InstanceFailoverGroup. </summary>
        public InstanceFailoverGroup()
        {
            PartnerRegions = new ChangeTrackingList<PartnerRegionInfo>();
            ManagedInstancePairs = new ChangeTrackingList<ManagedInstancePairInfo>();
        }

        /// <summary> Initializes a new instance of InstanceFailoverGroup. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="readWriteEndpoint"> Read-write endpoint of the failover group instance. </param>
        /// <param name="readOnlyEndpoint"> Read-only endpoint of the failover group instance. </param>
        /// <param name="replicationRole"> Local replication role of the failover group instance. </param>
        /// <param name="replicationState"> Replication state of the failover group instance. </param>
        /// <param name="partnerRegions"> Partner region information for the failover group. </param>
        /// <param name="managedInstancePairs"> List of managed instance pairs in the failover group. </param>
        internal InstanceFailoverGroup(string id, string name, string type, InstanceFailoverGroupReadWriteEndpoint readWriteEndpoint, InstanceFailoverGroupReadOnlyEndpoint readOnlyEndpoint, InstanceFailoverGroupReplicationRole? replicationRole, string replicationState, IList<PartnerRegionInfo> partnerRegions, IList<ManagedInstancePairInfo> managedInstancePairs) : base(id, name, type)
        {
            ReadWriteEndpoint = readWriteEndpoint;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            PartnerRegions = partnerRegions;
            ManagedInstancePairs = managedInstancePairs;
        }

        /// <summary> Read-write endpoint of the failover group instance. </summary>
        public InstanceFailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
        /// <summary> Read-only endpoint of the failover group instance. </summary>
        public InstanceFailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }
        /// <summary> Local replication role of the failover group instance. </summary>
        public InstanceFailoverGroupReplicationRole? ReplicationRole { get; }
        /// <summary> Replication state of the failover group instance. </summary>
        public string ReplicationState { get; }
        /// <summary> Partner region information for the failover group. </summary>
        public IList<PartnerRegionInfo> PartnerRegions { get; }
        /// <summary> List of managed instance pairs in the failover group. </summary>
        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; }
    }
}
