#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 2d plate that will be rendered always facing the camera.</summary>
[CppInclude("ImagePlateComponent.h")]
public partial class UImagePlateComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Add an image plate to this actor</summary>
	public  void SetImagePlate(FImagePlateParameters Plate) {}
	///<summary>Get this actor&#39;s image plates</summary>
	public  FImagePlateParameters GetPlate() { return default; }
	///<summary>Called by sequencer if a texture is changed</summary>
	public  void OnRenderTextureChanged() {}
	///<summary>Array of image plates to render for this component</summary>
	public FImagePlateParameters Plate;
	///<summary>EditorFrustum</summary>
	public UImagePlateFrustumComponent EditorFrustum;
}
