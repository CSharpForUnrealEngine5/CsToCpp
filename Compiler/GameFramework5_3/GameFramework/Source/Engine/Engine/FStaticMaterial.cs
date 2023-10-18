namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
public partial struct FStaticMaterial {
	public UMaterialInterface MaterialInterface;
	public FName MaterialSlotName;
	public FName ImportedMaterialSlotName;
	public FMeshUVChannelInfo UVChannelData;
}
