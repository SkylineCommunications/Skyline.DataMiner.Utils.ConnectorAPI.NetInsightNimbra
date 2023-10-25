namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Defines the Acceptable Frame Type options.
    /// </summary>
    public enum AcceptableFrameType
    {
        /// <summary>
        /// All frames, regardless of whether they have a VLAN tag or not, shall be accepted.
        /// </summary>
        All = 1,

        /// <summary>
        /// Only frames that contain a non-zero VLAN id in the VLAN tag shall be accepted.
        /// </summary>
        VlanTagged = 2,

        /// <summary>
        /// Only frames without a VLAN tag or with VLAN id zero shall be accepted.
        /// </summary>
        Untagged = 3,
    }

    /// <summary>
    /// Represents the operation status in the Service Table of the node.
    /// </summary>
    public enum ServiceOperationStatusNode
    {
        /// <summary>
        /// Represents a state where the service's status is not recognized or determined.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Indicates that the service is operational and functioning properly.
        /// </summary>
        Up = 1,

        /// <summary>
        /// Indicates that the service is not operational due to some faults or issues.
        /// </summary>
        Down = 2,

        /// <summary>
        /// Indicates that the service is partially operational. Some components may be up while others might be down.
        /// </summary>
        Partial = 3,

        /// <summary>
        /// Indicates that the service is in a passive or inactive state, possibly awaiting activation or external triggers.
        /// </summary>
        Dormant = 5,

        /// <summary>
        /// Indicates that the service has been intentionally brought down for administrative reasons.
        /// </summary>
        AdminDown = 6,
    }

    /// <summary>
    /// Represents the status of the ETH Devices.
    /// </summary>
    public enum DeviceStatus
    {
        /// <summary>
        /// The device is present and accounted for in the system.
        /// </summary>
        Present = 1,

        /// <summary>
        /// The device is not present or not detected in the system.
        /// </summary>
        Absent = 2,

        /// <summary>
        /// The device present does not match the expected device or configuration.
        /// </summary>
        Mismatch = 3,
    }

    /// <summary>
    /// Represents the version of the DCP.
    /// </summary>
    public enum DcpVersion
    {
        /// <summary>
        /// The system will automatically determine the DCP version.
        /// </summary>
        Auto = 1,

        /// <summary>
        /// Refers to the second version of the DCP.
        /// </summary>
        Dcp2 = 2,

        /// <summary>
        /// Refers to the third version of the DCP.
        /// </summary>
        Dcp3 = 3,
    }

    /// <summary>
    /// Represents the mode of the connection between the original node and destination nodes.
    /// </summary>
    public enum DestinationMode
    {
        /// <summary>
        /// The connection is made directly to a single recipient.
        /// </summary>
        Unicast = 1,

        /// <summary>
        /// The connection is made to multiple recipients simultaneously.
        /// </summary>
        Multicast = 2,

        /// <summary>
        /// The mode of the connection is not specified or determined.
        /// </summary>
        Unspecified = 3,
    }

    /// <summary>
    /// Represents a boolean value as defined in RFC2579.
    /// </summary>
    public enum TruthValue
    {
        /// <summary>
        /// The value or statement is true.
        /// </summary>
        True = 1,

        /// <summary>
        /// The value or statement is false.
        /// </summary>
        False = 2,
    }

    /// <summary>
    /// Represents the expected channel status when adding the ETH group.
    /// </summary>
    public enum ExpectChannelStatusOptions
    {
        /// <summary>
        /// The channel is expected to terminate upon adding to the ETH group.
        /// </summary>
        ExpectedToTerminate = 1,

        /// <summary>
        /// The channel is not expected to terminate upon adding to the ETH group.
        /// </summary>
        NotExceptedToTerminate = 2,
    }

    /// <summary>
    /// Defines the options on how the forwarding function shall handle unicast frames when it does not know what interface to use for reaching a destination.
    /// </summary>
    public enum MacMode
    {
        /// <summary>
        /// Equivalent to <see cref="Mac" /> if the forwarding function is connected to at least three interfaces, otherwise equivalent to <see cref="NoMac" />.
        /// </summary>
        Auto = 1,

        /// <summary>
        ///  The forwarding function will learn what interfaces to use for a destination.
        ///  This is done by looking at the source MAC address on received frames.
        ///  When the forwarding function has learned what interface to use, it will forward the frame on that interface only.
        /// </summary>
        Mac = 2,

        /// <summary>
        /// The forwarding function will forward the frame on all its interfaces.
        /// </summary>
        NoMac = 3,
    }

    /// <summary>
    /// Defines the Ethernet Interface Priority Mode options.
    /// </summary>
    public enum PriorityMode
    {
        /// <summary>
        /// The user bits are used.
        /// </summary>
        Ethernet = 1,

        /// <summary>
        /// The differential service code point (DSCP) field of the IP header is translated using the ethFwdDiffservTable into a flow group.
        /// </summary>
        DifferentialService = 2,
    }

    /// <summary>
    /// Represents the protection type of the DTM connection.
    /// </summary>
    public enum ProtectionType
    {
        /// <summary>
        /// If you don't want to change the setting, use none.
        /// </summary>
        None = 0,

        /// <summary>
        /// Hitless protection mode
        /// This refers to a system's ability to switch over to a backup or redundant path without causing any noticeable interruption or "hit" to the service.
        /// </summary>
        Hitless = 1,

        /// <summary>
        /// Standby protection mode
        /// This refers to a protection scheme where a backup or redundant path/component is kept in a "standby" mode, ready to take over operations if the primary path/component fails.
        /// </summary>
        Standby = 2,
    }

    /// <summary>
    /// Defines the different protection expected options.
    /// </summary>
    public enum ProtectionTypeExpected
    {
        /// <summary>
        /// If you don't want to change the setting, use none.
        /// </summary>
        None = 0,

        /// <summary>
        /// Unavailable.
        /// </summary>
        Unavailable = 1,

        /// <summary>
        /// Unprotected.
        /// </summary>
        Unprotected = 2,

        /// <summary>
        /// StandbyProtected.
        /// </summary>
        StandbyProtected = 3,

        /// <summary>
        /// HitlessCapable.
        /// </summary>
        HitlessCapable = 4,

        /// <summary>
        /// HitlessProtected.
        /// </summary>
        HitlessProtected = 5,
    }

    /// <summary>
    /// Represents the method for re-establishing TTP connection.
    /// </summary>
    public enum ReestablishMethod
    {
        /// <summary>
        /// Represents an exponential backoff method where the delay between
        /// reconnection attempts doubles with each subsequent attempt.
        /// This method helps avoid flooding the target with too many
        /// connection attempts in a short time span.
        /// </summary>
        Exponential = 1,
    }

    /// <summary>
    /// Defines the possible types of Source Routes.
    /// </summary>
    public enum RouteType
    {
        /// <summary>
        /// The channel must only pass the hops defined in the source route.
        /// </summary>
        Strict = 1,

        /// <summary>
        /// The channel must pass all the hops defined in the source route.
        /// </summary>
        Loose = 2,
    }

    /// <summary>
    /// Defines the possible types of Route Numbers.
    /// </summary>
    public enum RouteNbrs
    {
        /// <summary>
        /// The first route.
        /// </summary>
        Route1 = 0,

        /// <summary>
        /// The second route.
        /// </summary>
        Route2 = 1,

        /// <summary>
        /// The third route.
        /// </summary>
        Route3 = 2,

        /// <summary>
        /// The node will take the next available route.
        /// </summary>
        NextRoute = 3,
    }

    /// <summary>
    /// Defines the available options to handle incoming spanning tree messages.
    /// </summary>
    public enum SpanningTree
    {
        /// <summary>
        /// If the device does not implement the spanning-tree protocol, or if exactly two interfaces are connected to the forwarding function,
        /// then it will act as if <see cref="Forward" /> has been specified.
        /// Otherwise, it will act as if <see cref="Process" /> has been specified.
        /// </summary>
        Auto = 1,

        /// <summary>
        /// Received spanning-tree messages are broadcasted to all interfaces except the interface where the message was received. No further processing is done.
        /// </summary>
        Forward = 2,

        /// <summary>
        /// Received spanning-tree messages are dropped without any further processing.
        /// </summary>
        Drop = 3,

        /// <summary>
        /// Received spanning-tree messages are processed according to the spanning-tree protocol.
        /// </summary>
        Process = 4,
    }

    /// <summary>
    /// Represents the options for suppressing the alarm when adding the ITS Destination
    /// </summary>
    public enum SuppressAlarm
    {
        /// <summary>
        /// Indicates that alarm suppression is not supported for the ITS Destination.
        /// </summary>
        NotSupported = 0,

        /// <summary>
        /// No alarms will be suppressed. All alarms will be reported as they occur.
        /// </summary>
        None = 1,

        /// <summary>
        /// Only warning alarms will be suppressed. Critical alarms will still be reported.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// All types of alarms, whether critical or warning, will be suppressed.
        /// </summary>
        All = 3,
    }

    /// <summary>
    /// Defines the transmitted frames options.
    /// </summary>
    public enum TxFrameType
    {
        /// <summary>
        ///  VLAN tags on forwarded frames are removed according to setting of ethFwdVLANMode. 'VLAN Mode (ETH Fwd Func Table)'.
        /// </summary>
        VlanTagged = 2,

        /// <summary>
        /// VLAN tags on forwarded frames are removed according to setting of ethFwdVLANMode. 'VLAN Mode (ETH Fwd Func Table)'.
        /// </summary>
        Untagged = 3,

        /// <summary>
        /// VLAN id is transported together with frame, but the frame is in itself not tagged.
        /// </summary>
        Legacy = 4,
    }

    /// <summary>
    /// Defines the options that can be performed on received frames.
    /// </summary>
    public enum VlanMode
    {
        /// <summary>
        /// Ignore VLAN tags on received frames. VLAN tags are not added nor removed from the frames.
        /// If a frame has a VLAN tag, then it is retained. If a frame does not have a VLAN tag, then no tag is added.
        /// </summary>
        Transparent = 1,

        /// <summary>
        /// VLAN-handling in accordance with IEEE 802.1Q.
        /// Frames are forwarded and filtered according to customer VLAN tag.
        /// Frames that are not tagged are tagged with default VLAN tag as configured on the interface.
        /// </summary>
        Customer = 2,

        /// <summary>
        /// VLAN-handling in accordance with IEEE 802.1ad.
        /// Frames are forwarded and filtered according to service VLAN tag.Any customer VLAN is ignored.
        /// Frames that are not tagged are tagged with default VLAN tag as configured on the interface.
        /// </summary>
        Provider = 3,
    }

    /// <summary>
    /// Represents the Administrative status of the DTM connection.
    /// </summary>
    public enum AdminState
    {
        /// <summary>
        /// The DTM connection is operational and allowed to transmit data.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The DTM connection is administratively shut down and not allowed to transmit data.
        /// </summary>
        Down = 2,
    }

    /// <summary>
    /// Represents the possible SNMP RowStatus options.
    /// </summary>
    public enum RowStatus
    {
        /// <summary>
        /// The row is currently in use and operational.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The row is configured but not currently in service.
        /// </summary>
        NotInService = 2,

        /// <summary>
        /// The row is known but not ready to be put into service.
        /// </summary>
        NotReady = 3,

        /// <summary>
        /// The row should be created and immediately used.
        /// </summary>
        CreateAndGo = 4,

        /// <summary>
        /// The row should be created but wait for further instruction to be used.
        /// </summary>
        CreateAndWait = 5,

        /// <summary>
        /// The row should be removed from the table.
        /// </summary>
        Destroy = 6,
    }

    /// <summary>
    /// Represents the possible SNMP rowstatus options in DataMiner for table rows.
    /// </summary>
    public enum DataMinerSnmpRowStatus
    {
        /// <summary>
        /// The row has been updated with new values.
        /// </summary>
        Updated = 1,

        /// <summary>
        /// The row's current values are equal to the previous state.
        /// </summary>
        Equal = 2,

        /// <summary>
        /// A new row has been added to the table.
        /// </summary>
        New = 3,

        /// <summary>
        /// The row has been deleted from the table.
        /// </summary>
        Deleted = 4,

        /// <summary>
        /// The row has been recreated after being deleted.
        /// </summary>
        Recreated = 5,
    }

    /// <summary>
    /// Represents the operation status in Service Table of the Manager.
    /// </summary>
    public enum ServiceOperationStatusManager
    {
        /// <summary>
        /// The status of the service is not determined.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The service is operational and running without any issues.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The service has encountered an issue and is not operational.
        /// </summary>
        Down = 2,

        /// <summary>
        /// The service is partially operational with some components or functionalities not working as expected.
        /// </summary>
        Partial = 3,

        /// <summary>
        /// The service is in a standby or backup state but not active.
        /// </summary>
        Dormant = 4,

        /// <summary>
        /// The service has been manually brought down by an administrator.
        /// </summary>
        AdminDown = 5,
    }

    /// <summary>
    /// Represents the operation status in the destination Table.
    /// </summary>
    public enum DstOperationStatus
    {
        /// <summary>
        /// The status of the operation is not determined.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The operation is running without any issues.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The operation has encountered a problem and is not running.
        /// </summary>
        Down = 2,

        /// <summary>
        /// The operation has been manually brought down by an administrator.
        /// </summary>
        AdminDown = 3,
    }

    /// <summary>
    /// Represents the operation status in the Channel Table.
    /// </summary>
    public enum ChannelOperationStatus
    {
        /// <summary>
        /// The channel is operational and running without any issues.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The channel has encountered a problem and is not operational.
        /// </summary>
        Down = 2,

        /// <summary>
        /// The channel has been manually brought down by an administrator.
        /// </summary>
        AdminDown = 3,
    }

    /// <summary>
    /// Represents the hidden operation status in Channel Table.
    /// </summary>
    public enum ChannelOperationStatusHidden
    {
        /// <summary>
        /// The hidden channel is operational and running without any issues.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The hidden channel has encountered a problem and is not operational.
        /// </summary>
        Down = 2,
    }

    /// <summary>
    /// Represents the types of the DTM link.
    /// </summary>
    public enum DtmLinkTypes
    {
        /// <summary>
        /// The DTM link is local to the device or system.
        /// </summary>
        Local = 0,

        /// <summary>
        /// The DTM link is set to receive data.
        /// </summary>
        Rx = 1,

        /// <summary>
        /// The DTM link is set to transmit data.
        /// </summary>
        Tx = 2,
    }

    /// <summary>
    /// Represents the type of the Nimbra service.
    /// </summary>
    public enum ServiceTypes
    {
        /// <summary>
        /// The service type does not match any of the known types.
        /// </summary>
        Other = 0,

        /// <summary>
        /// Integrated Transport Service type for Nimbra.
        /// </summary>
        ITS = 1,

        /// <summary>
        /// Ethernet Transport Service type for Nimbra.
        /// </summary>
        ETS = 2,
    }

    /// <summary>
    /// Specifies the method used for removal.
    /// </summary>
    public enum RemoveOptions
    {
        /// <summary>
        /// Indicates a normal removal method.
        /// </summary>
        Soft,

        /// <summary>
        /// Indicates a forced removal method.
        /// </summary>
        Hard,
    }
}