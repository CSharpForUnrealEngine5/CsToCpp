#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>material settings for mesh inspector tool</summary>
[CppInclude("MeshInspectorTool.h")]
public partial class UMeshInspectorMaterialProperties : UInteractiveToolPropertySet {
	///<summary>Material that will be used to render the mesh</summary>
	public EMeshInspectorMaterialMode MaterialMode;
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
	///<summary>Toggle flat shading on/off</summary>
	public bool bFlatShading;
	///<summary>Main Color of Material</summary>
	public FLinearColor Color;
	///<summary>Opacity of transparent material</summary>
	public double Opacity;
	///<summary>TransparentMaterialColor</summary>
	public FLinearColor TransparentMaterialColor;
	///<summary>Although a two-sided transparent material causes rendering issues with overlapping faces, it is still frequently useful to see the shape when sculpting around other objects.</summary>
	public bool bTwoSided;
	///<summary>CheckerMaterial</summary>
	public UMaterialInstanceDynamic CheckerMaterial;
	///<summary>ActiveCustomMaterial</summary>
	public UMaterialInstanceDynamic ActiveCustomMaterial;
}
