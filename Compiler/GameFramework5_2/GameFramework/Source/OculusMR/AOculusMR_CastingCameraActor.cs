#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_CastingCameraActor.h")]
///<summary>The camera actor in the level that tracks the binded physical camera in game</summary>
public partial class AOculusMR_CastingCameraActor : ASceneCapture2D {
// OculusMR_CastingCameraActor
	public UVRNotificationsComponent VRNotificationComponent;
	public UTexture2D CameraColorTexture;
	public UTexture2D CameraDepthTexture;
	public UOculusMR_PlaneMeshComponent PlaneMeshComponent;
	public UMaterial ChromaKeyMaterial;
	public UMaterial OpaqueColoredMaterial;
	public UMaterialInstanceDynamic ChromaKeyMaterialInstance;
	public UMaterialInstanceDynamic CameraFrameMaterialInstance;
	public UMaterialInstanceDynamic BackdropMaterialInstance;
	public UTexture2D DefaultTexture_White;
	public TArray<UTextureRenderTarget2D> BackgroundRenderTargets;
	public ASceneCapture2D ForegroundCaptureActor;
	public TArray<UTextureRenderTarget2D> ForegroundRenderTargets;
	public TArray<double> PoseTimes;
	public UDEPRECATED_UOculusMR_Settings MRSettings_DEPRECATED;
	public UOculusMR_State MRState;
}
