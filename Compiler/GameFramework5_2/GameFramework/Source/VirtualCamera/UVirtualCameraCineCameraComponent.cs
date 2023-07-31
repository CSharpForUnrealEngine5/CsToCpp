#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraCineCameraComponent.h")]
public partial class UVirtualCameraCineCameraComponent : UCineCameraComponent {
	///<summary>List of preset aperture options, aperture will always be one of these values</summary>
	public TArray<float> ApertureOptions;
	///<summary>List of preset focal length options, focal length will be one of these values, unless manually zooming</summary>
	public TArray<float> FocalLengthOptions;
	///<summary>List of preset matte options to chose from, UI options will only pull from this, unless a filmback option with a custom matte is selected</summary>
	public TArray<float> MatteOptions;
	///<summary>List of preset filmback options, filmback will always be one of these values</summary>
	public TMap<string,FCameraFilmbackSettings> FilmbackOptions;
	///<summary>The desired filmback settings to be shown in the viewport within Virtual Camera UI window</summary>
	public FCameraFilmbackSettings DesiredFilmbackSettings;
	///<summary>The filmback settings to be used for additional letterboxing if desired</summary>
	public float MatteAspectRatio;
	///<summary>The opacity of the matte in the camera view</summary>
	public float MatteOpacity;
	///<summary>The X and Y ratios of Desired View Size to Actual View Size (calculated as Desired/ Actual)</summary>
	public FVector2D ViewSizeRatio;
}
