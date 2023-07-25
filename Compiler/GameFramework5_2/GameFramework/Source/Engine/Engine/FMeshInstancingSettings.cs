#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
///<summary>Mesh instance-replacement settings</summary>
public partial struct FMeshInstancingSettings {
// MeshInstancingSettings
	public UClass ActorClassToUse;
	public int InstanceReplacementThreshold;
	public bool bSkipMeshesWithVertexColors;
	public bool bUseHLODVolumes;
	public UClass ISMComponentToUse;
}
