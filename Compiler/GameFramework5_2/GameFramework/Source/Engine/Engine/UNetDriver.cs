namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetDriver.h")]
public partial class UNetDriver : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Used to specify the class to use for connections</summary>
	public string NetConnectionClassName;
	///<summary>ReplicationDriverClassName</summary>
	public string ReplicationDriverClassName;
	///<summary>Used to specify the class to use for ReplicationBridge</summary>
	public string ReplicationBridgeClassName;
	///<summary>@todo document</summary>
	public int MaxDownloadSize;
	///<summary>@todo document</summary>
	public bool bClampListenServerTickRate;
	///<summary>@todo document</summary>
	public int NetServerMaxTickRate;
	///<summary>Limit tick rate of replication to allow very high frame rates to still replicate data. A value less or equal to zero means use the engine tick rate. A value greater than zero will clamp the net tick rate to this value.</summary>
	public int MaxNetTickRate;
	///<summary>@todo document</summary>
	public int MaxInternetClientRate;
	///<summary>@todo document</summary>
	public int MaxClientRate;
	///<summary>Amount of time a server will wait before traveling to next map, gives clients time to receive final RPCs on existing level See: NextSwitchCountdown</summary>
	public float ServerTravelPause;
	///<summary>@todo document</summary>
	public float SpawnPrioritySeconds;
	///<summary>@todo document</summary>
	public float RelevantTimeout;
	///<summary>@todo document</summary>
	public float KeepAliveTime;
	///<summary>Amount of time to wait for a new net connection to be established before destroying the connection</summary>
	public float InitialConnectTimeout;
	///<summary>Amount of time to wait before considering an established connection timed out.</summary>
	public float ConnectionTimeout;
	///<summary>A multiplier that is applied to the above values when we are running with unoptimized builds (debug)</summary>
	public float TimeoutMultiplierForUnoptimizedBuilds;
	///<summary>Connection to the server (this net driver is a client)</summary>
	public UNetConnection ServerConnection;
	///<summary>Array of connections to clients (this net driver is a host) - unsorted, and ordering changes depending on actor replication</summary>
	public TArray<UNetConnection> ClientConnections;
	///<summary>The amount of time, in seconds, that recently disconnected clients should be tracked</summary>
	public int RecentlyDisconnectedTrackingTime;
	///<summary>World this net driver is associated with</summary>
	public UWorld World;
	///<summary>WorldPackage</summary>
	public UPackage WorldPackage;
	///<summary>The loaded UClass of the net connection type to use</summary>
	public UClass NetConnectionClass;
	///<summary>ReplicationDriverClass</summary>
	public UClass ReplicationDriverClass;
	///<summary>ReplicationBridgeClass</summary>
	public UClass ReplicationBridgeClass;
	///<summary>Used to specify the net driver to filter actors with (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
	public string NetDriverName;
	///<summary>Used to specify available channel types and their associated UClass</summary>
	public TArray<FChannelDefinition> ChannelDefinitions;
	///<summary>Used for faster lookup of channel definitions by name.</summary>
	public TMap<string,FChannelDefinition> ChannelDefinitionMap;
	///<summary>List of channels that were previously used and can be used again</summary>
	public TArray<UChannel> ActorChannelPool;
	///<summary>If true, ignore timeouts completely.  Should be used only in development</summary>
	public bool bNoTimeouts;
	///<summary>If true this NetDriver will not apply the network emulation settings that simulate</summary>
	public bool bNeverApplyNetworkEmulationSettings;
	///<summary>ReplicationDriver</summary>
	public UReplicationDriver ReplicationDriver;
}
