#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object to bind to a APlayerCameraManager with a UTextureRenderTarget2D to be used as a player&#39;s render target.</summary>
[CppInclude("ComposurePlayerCompositingTarget.h")]
public partial class UComposurePlayerCompositingTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current player camera manager the target is bind on.</summary>
	public  APlayerCameraManager GetPlayerCameraManager() { return default; }
	///<summary>Set player camera manager to bind the render target to.</summary>
	public  APlayerCameraManager SetPlayerCameraManager(APlayerCameraManager PlayerCameraManager) { return default; }
	///<summary>Set the render target of the player.</summary>
	public  void SetRenderTarget(UTextureRenderTarget2D RenderTarget) {}
	///<summary>Current player camera manager the target is bind on.</summary>
	public APlayerCameraManager PlayerCameraManager;
	///<summary>Underlying player camera modifier</summary>
	public UComposurePlayerCompositingCameraModifier PlayerCameraModifier;
	///<summary>Post process material that replaces the tonemapper to dump the player&#39;s render target.</summary>
	public UMaterialInstanceDynamic ReplaceTonemapperMID;
}
