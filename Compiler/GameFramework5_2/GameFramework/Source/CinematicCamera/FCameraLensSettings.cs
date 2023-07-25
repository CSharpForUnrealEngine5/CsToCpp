#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
///<summary>#note, this struct has a details customization in CameraLensSettingsCustomization.cpp/h</summary>
public partial struct FCameraLensSettings {
// CameraLensSettings
	public float MinFocalLength;
	public float MaxFocalLength;
	public float MinFStop;
	public float MaxFStop;
	public float MinimumFocusDistance;
	public float SqueezeFactor;
	public int DiaphragmBladeCount;
}
