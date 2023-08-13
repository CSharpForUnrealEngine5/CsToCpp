namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component intended to replace UComposurePlayerCompositingTarget - a object to bind to a APlayerCameraManager</summary>
[CppInclude("ComposurePlayerCompositingTarget.h")]
public partial class UComposureCompositingTargetComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetDisplayTexture</summary>
	public void SetDisplayTexture(UTexture DisplayTexture) {}
	///<summary>GetDisplayTexture</summary>
	public UTexture GetDisplayTexture() { return default; }
	///<summary>DisplayTexture</summary>
	public UTexture DisplayTexture;
	///<summary>CompilerErrImage</summary>
	public UTexture CompilerErrImage;
}
