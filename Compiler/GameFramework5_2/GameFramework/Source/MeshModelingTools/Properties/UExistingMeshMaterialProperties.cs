#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshMaterialProperties.h")]
///<summary>Standard material property settings for tools that visualize materials on existing meshes (e.g. to help show UVs)</summary>
public partial class UExistingMeshMaterialProperties : UInteractiveToolPropertySet {
// ExistingMeshMaterialProperties
	public ESetMeshMaterialMode MaterialMode;
	public float CheckerDensity;
	public UMaterialInterface OverrideMaterial;
	public string UVChannel;
	public TArray<string> UVChannelNamesList;
	public TArray<string> GetUVChannelNamesFunc() { return default; }
	public UMaterialInstanceDynamic CheckerMaterial;
}
