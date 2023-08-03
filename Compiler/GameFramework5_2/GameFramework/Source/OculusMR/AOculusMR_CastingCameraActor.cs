#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The camera actor in the level that tracks the binded physical camera in game</summary>
[CppInclude("OculusMR_CastingCameraActor.h")]
public partial class AOculusMR_CastingCameraActor : ASceneCapture2D {
	public static UClass StaticClass() {return default;}
	///<summary>VRNotificationComponent</summary>
	public UVRNotificationsComponent VRNotificationComponent;
	///<summary>CameraColorTexture</summary>
	public UTexture2D CameraColorTexture;
	///<summary>CameraDepthTexture</summary>
	public UTexture2D CameraDepthTexture;
	///<summary>PlaneMeshComponent</summary>
	public UOculusMR_PlaneMeshComponent PlaneMeshComponent;
	///<summary>ChromaKeyMaterial</summary>
	public UMaterial ChromaKeyMaterial;
	///<summary>OpaqueColoredMaterial</summary>
	public UMaterial OpaqueColoredMaterial;
	///<summary>ChromaKeyMaterialInstance</summary>
	public UMaterialInstanceDynamic ChromaKeyMaterialInstance;
	///<summary>CameraFrameMaterialInstance</summary>
	public UMaterialInstanceDynamic CameraFrameMaterialInstance;
	///<summary>BackdropMaterialInstance</summary>
	public UMaterialInstanceDynamic BackdropMaterialInstance;
	///<summary>DefaultTexture_White</summary>
	public UTexture2D DefaultTexture_White;
	///<summary>BackgroundRenderTargets</summary>
	public TArray<UTextureRenderTarget2D> BackgroundRenderTargets;
	///<summary>ForegroundCaptureActor</summary>
	public ASceneCapture2D ForegroundCaptureActor;
	///<summary>ForegroundRenderTargets</summary>
	public TArray<UTextureRenderTarget2D> ForegroundRenderTargets;
	///<summary>PoseTimes</summary>
	public TArray<double> PoseTimes;
	///<summary>MRSettings_DEPRECATED</summary>
	public UDEPRECATED_UOculusMR_Settings MRSettings_DEPRECATED;
	///<summary>MRState</summary>
	public UOculusMR_State MRState;
}
