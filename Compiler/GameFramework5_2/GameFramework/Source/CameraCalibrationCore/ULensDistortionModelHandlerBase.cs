#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data that can be used on Camera Actors to manage lens distortion state and utilities</summary>
[CppInclude("LensDistortionModelHandlerBase.h")]
public partial class ULensDistortionModelHandlerBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the input model is supported by this model handler, false otherwise.</summary>
	public  bool IsModelSupported(UClass ModelToSupport) { return default; }
	///<summary>Update the lens distortion state, recompute the overscan factor, and set all material parameters</summary>
	public  void SetDistortionState(FLensDistortionState InNewState) {}
	///<summary>Get the UV displacement map used to undistort a distorted image</summary>
	public  UTextureRenderTarget2D GetUndistortionDisplacementMap() { return default; }
	///<summary>Get the UV displacement map used to distort an undistorted image</summary>
	public  UTextureRenderTarget2D GetDistortionDisplacementMap() { return default; }
	///<summary>Lens Model describing how to interpret the distortion parameters</summary>
	public UClass LensModelClass;
	///<summary>Dynamically created post-process material instance for the currently specified lens model</summary>
	public UMaterialInstanceDynamic DistortionPostProcessMID;
	///<summary>Current state as set by the most recent call to Update()</summary>
	public FLensDistortionState CurrentState;
	///<summary>Filmback settings of the camera that is being used for distortion</summary>
	public FCameraFilmbackSettings CameraFilmback;
	///<summary>Display name, used to identify handler in-editor details panels</summary>
	public string DisplayName;
	///<summary>Computed overscan factor needed to scale the camera&#39;s FOV (read-only)</summary>
	public float OverscanFactor;
	///<summary>MID used to draw the undistortion displacement map</summary>
	public UMaterialInstanceDynamic UndistortionDisplacementMapMID;
	///<summary>MID used to draw the distortion displacement map</summary>
	public UMaterialInstanceDynamic DistortionDisplacementMapMID;
	///<summary>UV displacement map used to undistort a distorted image</summary>
	public UTextureRenderTarget2D UndistortionDisplacementMapRT;
	///<summary>UV displacement map used to distort an undistorted image</summary>
	public UTextureRenderTarget2D DistortionDisplacementMapRT;
	///<summary>UObject that is producing the distortion state for this handler</summary>
	public FGuid DistortionProducerID;
}
