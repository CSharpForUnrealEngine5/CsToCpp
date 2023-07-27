#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePlayerCompositingTarget.h")]
///<summary>Component intended to replace UComposurePlayerCompositingTarget - a object to bind to a APlayerCameraManager</summary>
public partial class UComposureCompositingTargetComponent : UActorComponent {
// ComposureCompositingTargetComponent
	public  void SetDisplayTexture(UTexture DisplayTexture) {}
	public  UTexture GetDisplayTexture() { return default; }
	public UTexture DisplayTexture;
	public UTexture CompilerErrImage;
}
