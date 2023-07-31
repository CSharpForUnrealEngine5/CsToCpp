#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertVirtualCamera.h")]
public partial struct FConcertVirtualCameraCameraData {
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
