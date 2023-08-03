#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageType_InstancedStaticMesh.h")]
public partial class UFoliageType_InstancedStaticMesh : UFoliageType {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh</summary>
	public UStaticMesh Mesh;
	///<summary>Material overrides for foliage instances.</summary>
	public TArray<UMaterialInterface> OverrideMaterials;
	///<summary>Nanite material overrides for foliage instances.</summary>
	public TArray<UMaterialInterface> NaniteOverrideMaterials;
	///<summary>The component class to use for foliage instances.</summary>
	public UClass ComponentClass;
}
