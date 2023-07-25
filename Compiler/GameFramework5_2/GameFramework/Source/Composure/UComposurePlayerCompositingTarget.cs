#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePlayerCompositingTarget.h")]
///<summary>Object to bind to a APlayerCameraManager with a UTextureRenderTarget2D to be used as a player's render target.</summary>
public partial class UComposurePlayerCompositingTarget : UObject {
// ComposurePlayerCompositingTarget
	public UObject GetPlayerCameraManager() { return default; }
	public UObject SetPlayerCameraManager(UObject PlayerCameraManager) { return default; }
	public void SetRenderTarget(UObject RenderTarget) {}
	public APlayerCameraManager PlayerCameraManager;
	public UComposurePlayerCompositingCameraModifier PlayerCameraModifier;
	public UMaterialInstanceDynamic ReplaceTonemapperMID;
}
