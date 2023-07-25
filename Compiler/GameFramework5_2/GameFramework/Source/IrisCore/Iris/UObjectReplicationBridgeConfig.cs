#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/ObjectReplicationBridgeConfig.h")]
public partial class UObjectReplicationBridgeConfig : UObject {
// ObjectReplicationBridgeConfig
	public TArray<FObjectReplicationBridgePollConfig> PollConfigs;
	public TArray<FObjectReplicationBridgeFilterConfig> FilterConfigs;
	public TArray<FObjectReplicationBridgePrioritizerConfig> PrioritizerConfigs;
	public TArray<FObjectReplicationBridgeDeltaCompressionConfig> DeltaCompressionConfigs;
	public string DefaultSpatialFilterName;
	public string RequiredNetDriverChannelClassName;
}
