namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh instance-replacement settings</summary>
[CppInclude("Engine/MeshMerging.h")]
public partial struct FMeshInstancingSettings {
	public UClass ActorClassToUse;
	public int InstanceReplacementThreshold;
	public bool bSkipMeshesWithVertexColors;
	public bool bUseHLODVolumes;
	public UClass ISMComponentToUse;
}
