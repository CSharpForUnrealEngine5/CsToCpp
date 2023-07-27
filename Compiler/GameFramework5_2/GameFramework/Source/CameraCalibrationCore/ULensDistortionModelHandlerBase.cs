#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensDistortionModelHandlerBase.h")]
///<summary>Asset user data that can be used on Camera Actors to manage lens distortion state and utilities</summary>
public partial class ULensDistortionModelHandlerBase : UObject {
// LensDistortionModelHandlerBase
	public  bool IsModelSupported(UClass ModelToSupport) { return default; }
	public  void SetDistortionState(FLensDistortionState InNewState) {}
	public  UTextureRenderTarget2D GetUndistortionDisplacementMap() { return default; }
	public  UTextureRenderTarget2D GetDistortionDisplacementMap() { return default; }
	public UClass LensModelClass;
	public UMaterialInstanceDynamic DistortionPostProcessMID;
	public FLensDistortionState CurrentState;
	public FCameraFilmbackSettings CameraFilmback;
	public string DisplayName;
	public float OverscanFactor;
	public UMaterialInstanceDynamic UndistortionDisplacementMapMID;
	public UMaterialInstanceDynamic DistortionDisplacementMapMID;
	public UTextureRenderTarget2D UndistortionDisplacementMapRT;
	public UTextureRenderTarget2D DistortionDisplacementMapRT;
	public FGuid DistortionProducerID;
}
