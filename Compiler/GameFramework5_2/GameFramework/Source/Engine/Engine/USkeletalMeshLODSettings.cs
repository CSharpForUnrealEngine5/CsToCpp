#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshLODSettings.h")]
public partial class USkeletalMeshLODSettings : UDataAsset {
// SkeletalMeshLODSettings
	public FPerQualityLevelInt MinQualityLevelLod;
	public FPerPlatformInt MinLod;
	public FPerPlatformBool DisableBelowMinLodStripping;
	public bool bOverrideLODStreamingSettings;
	public FPerPlatformBool bSupportLODStreaming;
	public FPerPlatformInt MaxNumStreamedLODs;
	public FPerPlatformInt MaxNumOptionalLODs;
	public TArray<FSkeletalMeshLODGroupSettings> LODGroups;
}
