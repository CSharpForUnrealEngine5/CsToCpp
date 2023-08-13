namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshLODSettings.h")]
public partial class USkeletalMeshLODSettings : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum Quality Level LOD to render. Can be overridden per mesh as well as set here for all mesh instances</summary>
	public FPerQualityLevelInt MinQualityLevelLod;
	///<summary>Minimum LOD to render. Can be overridden per mesh as well as set here for all mesh instances</summary>
	public FPerPlatformInt MinLod;
	///<summary>When true LODs below MinLod will not be stripped during cook.</summary>
	public FPerPlatformBool DisableBelowMinLodStripping;
	///<summary>Whether meshes in this group override default LOD streaming settings.</summary>
	public bool bOverrideLODStreamingSettings;
	///<summary>Whether meshes in this group stream LODs by default</summary>
	public FPerPlatformBool bSupportLODStreaming;
	///<summary>Default maximum number of streamed LODs for meshes in this group</summary>
	public FPerPlatformInt MaxNumStreamedLODs;
	///<summary>Default maximum number of optional LODs for meshes in this group (currently, need to be either 0 or &gt; num of LODs below MinLod)</summary>
	public FPerPlatformInt MaxNumOptionalLODs;
	///<summary>LODGroups</summary>
	public TArray<FSkeletalMeshLODGroupSettings> LODGroups;
}
