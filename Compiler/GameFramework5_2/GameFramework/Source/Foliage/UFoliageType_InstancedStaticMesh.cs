#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageType_InstancedStaticMesh.h")]
public partial class UFoliageType_InstancedStaticMesh : UFoliageType {
// FoliageType_InstancedStaticMesh
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> OverrideMaterials;
	public TArray<UMaterialInterface> NaniteOverrideMaterials;
	public UClass ComponentClass;
}
