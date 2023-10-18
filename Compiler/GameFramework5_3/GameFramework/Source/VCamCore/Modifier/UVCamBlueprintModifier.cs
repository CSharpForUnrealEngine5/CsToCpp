namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifier.h")]
public partial class UVCamBlueprintModifier : UVCamModifier {
	public static UClass StaticClass() {return default;}
	///<summary>OnInitialize</summary>
	public void OnInitialize(UVCamModifierContext Context) {}
	///<summary>OnDeinitialize</summary>
	public void OnDeinitialize() {}
	///<summary>OnApply</summary>
	public void OnApply(UVCamModifierContext Context,UCineCameraComponent CameraComponent,float DeltaTime) {}
	///<summary>This function is deliberately non-working to force cleanup of Input Contexts</summary>
	public void GetInputMappingContextAndPriority() {}
}
