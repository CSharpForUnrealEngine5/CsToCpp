namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store lightmap data during RerunConstructionScripts</summary>
[CppInclude("Components/InstancedStaticMeshComponent.h")]
public partial struct FInstancedStaticMeshLightMapInstanceData {
	public FTransform Transform;
	public TArray<FGuid> MapBuildDataIds;
}
