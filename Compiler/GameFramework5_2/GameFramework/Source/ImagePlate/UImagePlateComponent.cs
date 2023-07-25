#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImagePlateComponent.h")]
///<summary>A 2d plate that will be rendered always facing the camera.</summary>
public partial class UImagePlateComponent : UPrimitiveComponent {
// ImagePlateComponent
	public void SetImagePlate(FImagePlateParameters Plate) {}
	public FImagePlateParameters GetPlate() { return default; }
	public void OnRenderTextureChanged() {}
	public FImagePlateParameters Plate;
	public UImagePlateFrustumComponent EditorFrustum;
}
