#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshMaterialProperties.h")]
public partial class UMeshEditingViewProperties : UInteractiveToolPropertySet {
	///<summary>Toggle drawing of wireframe overlay on/off [Alt+W]</summary>
	public bool bShowWireframe;
	///<summary>Set which material to use on object</summary>
	public EMeshEditingMaterialModes MaterialMode;
	///<summary>Toggle flat shading on/off</summary>
	public bool bFlatShading;
	///<summary>Main Color of Material</summary>
	public FLinearColor Color;
	///<summary>Image used in Image-Based Material</summary>
	public UTexture2D Image;
	///<summary>Opacity of transparent material</summary>
	public double Opacity;
	///<summary>TransparentMaterialColor</summary>
	public FLinearColor TransparentMaterialColor;
	///<summary>Although a two-sided transparent material causes rendering issues with overlapping faces, it is still frequently useful to see the shape when sculpting around other objects.</summary>
	public bool bTwoSided;
	///<summary>CustomMaterial</summary>
	public TWeakObjectPtr<UMaterialInterface> CustomMaterial;
}
