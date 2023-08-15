namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/ObjectReplicationBridgeConfig.h")]
public partial class UObjectReplicationBridgeConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Which classes should override how often they&#39;re polled for modified replicated properties.</summary>
	public TArray<FObjectReplicationBridgePollConfig> PollConfigs;
	///<summary>Which classes should apply a certain filter. Subclasses will inherit the settings unless</summary>
	public TArray<FObjectReplicationBridgeFilterConfig> FilterConfigs;
	///<summary>Which classes should apply a certain prioritizer. Subclasses will inherit the settings.</summary>
	public TArray<FObjectReplicationBridgePrioritizerConfig> PrioritizerConfigs;
	///<summary>Which classes should enable deltacompression. Derived classes will get the same behavior unless overidden</summary>
	public TArray<FObjectReplicationBridgeDeltaCompressionConfig> DeltaCompressionConfigs;
	///<summary>The name of the filter to apply objects that can have spatial filtering applied.</summary>
	public FName DefaultSpatialFilterName;
	///<summary>The name of the channel class required for object replication to work.</summary>
	public FName RequiredNetDriverChannelClassName;
}
