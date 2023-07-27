#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePlayerCompositingTarget.h")]
///<summary>Object to bind to a APlayerCameraManager with a UTextureRenderTarget2D to be used as a player's render target.</summary>
public partial class UComposurePlayerCompositingTarget : UObject {
// ComposurePlayerCompositingTarget
	public  APlayerCameraManager GetPlayerCameraManager() { return default; }
	public  APlayerCameraManager SetPlayerCameraManager(APlayerCameraManager PlayerCameraManager) { return default; }
	public  void SetRenderTarget(UTextureRenderTarget2D RenderTarget) {}
	public APlayerCameraManager PlayerCameraManager;
	public UComposurePlayerCompositingCameraModifier PlayerCameraModifier;
	public UMaterialInstanceDynamic ReplaceTonemapperMID;
}
