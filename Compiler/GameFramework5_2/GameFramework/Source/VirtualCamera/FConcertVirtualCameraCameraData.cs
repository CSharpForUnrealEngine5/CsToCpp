#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertVirtualCamera.h")]
public partial struct FConcertVirtualCameraCameraData {
// ConcertVirtualCameraCameraData
	public FVector CameraActorLocation;
	public FRotator CameraActorRotation;
	public FVector CameraComponentLocation;
	public FRotator CameraComponentRotation;
	public float CurrentAperture;
	public float CurrentFocalLength;
	public FConcertVirtualCameraCameraFocusData FocusSettings;
	public FCameraLensSettings LensSettings;
	public FCameraFilmbackSettings FilmbackSettings;
}
