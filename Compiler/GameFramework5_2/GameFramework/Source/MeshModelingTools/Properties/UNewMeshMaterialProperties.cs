#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshMaterialProperties.h")]
///<summary>Standard material property settings for tools that generate new meshes</summary>
public partial class UNewMeshMaterialProperties : UInteractiveToolPropertySet {
// NewMeshMaterialProperties
	public TWeakObjectPtr<UMaterialInterface> Material;
	public float UVScale;
	public bool bWorldSpaceUVScale;
	public bool bShowWireframe;
	public bool bShowExtendedOptions;
}
