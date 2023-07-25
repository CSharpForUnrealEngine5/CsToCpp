#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraCineCameraComponent.h")]
public partial class UVirtualCameraCineCameraComponent : UCineCameraComponent {
// VirtualCameraCineCameraComponent
	public TArray<float> ApertureOptions;
	public TArray<float> FocalLengthOptions;
	public TArray<float> MatteOptions;
	public TMap<string,FCameraFilmbackSettings> FilmbackOptions;
	public FCameraFilmbackSettings DesiredFilmbackSettings;
	public float MatteAspectRatio;
	public float MatteOpacity;
	public FVector2D ViewSizeRatio;
}
