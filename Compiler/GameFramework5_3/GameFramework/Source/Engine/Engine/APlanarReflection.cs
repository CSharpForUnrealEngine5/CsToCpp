namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlanarReflection.h")]
public partial class APlanarReflection : ASceneCapture {
	public static UClass StaticClass() {return default;}
	///<summary>Planar reflection component.</summary>
	public UPlanarReflectionComponent PlanarReflectionComponent;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>bShowPreviewPlane_DEPRECATED</summary>
	public bool bShowPreviewPlane_DEPRECATED;
	///<summary>OnInterpToggle</summary>
	public void OnInterpToggle(bool bEnable) {}
}
