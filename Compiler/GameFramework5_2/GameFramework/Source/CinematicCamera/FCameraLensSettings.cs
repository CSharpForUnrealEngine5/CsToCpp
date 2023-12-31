namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>#note, this struct has a details customization in CameraLensSettingsCustomization.cpp/h</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FCameraLensSettings {
	public float MinFocalLength;
	public float MaxFocalLength;
	public float MinFStop;
	public float MaxFStop;
	public float MinimumFocusDistance;
	public float SqueezeFactor;
	public int DiaphragmBladeCount;
}
