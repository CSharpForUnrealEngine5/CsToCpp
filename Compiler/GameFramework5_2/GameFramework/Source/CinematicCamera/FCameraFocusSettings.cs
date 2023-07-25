#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
///<summary>Settings to control camera focus</summary>
public partial struct FCameraFocusSettings {
// CameraFocusSettings
	public ECameraFocusMethod FocusMethod;
	public float ManualFocusDistance;
	public FCameraTrackingFocusSettings TrackingFocusSettings;
	public bool bDrawDebugFocusPlane;
	public FColor DebugFocusPlaneColor;
	public bool bSmoothFocusChanges;
	public float FocusSmoothingInterpSpeed;
	public float FocusOffset;
}
