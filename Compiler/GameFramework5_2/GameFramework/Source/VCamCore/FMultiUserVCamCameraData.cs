#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamMultiUser.h")]
public partial struct FMultiUserVCamCameraData {
// MultiUserVCamCameraData
	public FVector CameraActorLocation;
	public FRotator CameraActorRotation;
	public FVector CameraComponentLocation;
	public FRotator CameraComponentRotation;
	public float CurrentAperture;
	public float CurrentFocalLength;
	public FMultiUserVCamCameraFocusData FocusSettings;
	public FCameraLensSettings LensSettings;
	public FCameraFilmbackSettings FilmbackSettings;
	public bool bOverride_NearClipPlane;
	public bool bOverride_CameraISO;
	public float CustomNearClipPlane;
	public float CameraISO;
	public float AutoExposureBias;
}
