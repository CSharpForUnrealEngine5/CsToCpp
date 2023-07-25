#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshMaterialProperties.h")]
public partial class UMeshEditingViewProperties : UInteractiveToolPropertySet {
// MeshEditingViewProperties
	public bool bShowWireframe;
	public EMeshEditingMaterialModes MaterialMode;
	public bool bFlatShading;
	public FLinearColor Color;
	public UTexture2D Image;
	public double Opacity;
	public FLinearColor TransparentMaterialColor;
	public bool bTwoSided;
	public TWeakObjectPtr<UMaterialInterface> CustomMaterial;
}
