#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlanarReflection.h")]
public partial class APlanarReflection : ASceneCapture {
	///<summary>Planar reflection component.</summary>
	public UPlanarReflectionComponent PlanarReflectionComponent;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>bShowPreviewPlane_DEPRECATED</summary>
	public bool bShowPreviewPlane_DEPRECATED;
	///<summary>OnInterpToggle</summary>
	public  void OnInterpToggle(bool bEnable) {}
}
