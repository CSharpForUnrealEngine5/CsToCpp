#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard material property settings for tools that visualize materials on existing meshes (e.g. to help show UVs)</summary>
[CppInclude("Properties/MeshMaterialProperties.h")]
public partial class UExistingMeshMaterialProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Material that will be used on the mesh</summary>
	public ESetMeshMaterialMode MaterialMode;
	///<summary>Number of checkerboard tiles within the 0 to 1 range; only available when Checkerboard is selected as material mode</summary>
	public float CheckerDensity;
	///<summary>Material to use instead of the original material; only available when Override is selected as material mode</summary>
	public UMaterialInterface OverrideMaterial;
	///<summary>Which UV channel to use for visualizing the checkerboard material on the mesh; note that this does not affect the preview layout</summary>
	public string UVChannel;
	///<summary>UVChannelNamesList</summary>
	public TArray<string> UVChannelNamesList;
	///<summary>GetUVChannelNamesFunc</summary>
	public  TArray<string> GetUVChannelNamesFunc() { return default; }
	///<summary>CheckerMaterial</summary>
	public UMaterialInstanceDynamic CheckerMaterial;
}
