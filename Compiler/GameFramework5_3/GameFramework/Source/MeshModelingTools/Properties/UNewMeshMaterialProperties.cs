namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard material property settings for tools that generate new meshes</summary>
[CppInclude("Properties/MeshMaterialProperties.h")]
public partial class UNewMeshMaterialProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Material for new mesh</summary>
	public TWeakObjectPtr<UMaterialInterface> Material;
	///<summary>Scale factor for generated UVs</summary>
	public float UVScale;
	///<summary>If true, UV scale will be relative to world space. This means objects of different sizes created with the same UV scale have the same average texel size.</summary>
	public bool bWorldSpaceUVScale;
	///<summary>If true, overlays preview with wireframe</summary>
	public bool bShowWireframe;
	///<summary>If true, extended options are available</summary>
	public bool bShowExtendedOptions;
}
