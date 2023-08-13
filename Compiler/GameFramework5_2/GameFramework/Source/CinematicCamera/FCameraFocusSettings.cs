namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to control camera focus</summary>
[CppInclude("CineCameraSettings.h")]
public partial struct FCameraFocusSettings {
	public ECameraFocusMethod FocusMethod;
	public float ManualFocusDistance;
	public FCameraTrackingFocusSettings TrackingFocusSettings;
	public bool bDrawDebugFocusPlane;
	public FColor DebugFocusPlaneColor;
	public bool bSmoothFocusChanges;
	public float FocusSmoothingInterpSpeed;
	public float FocusOffset;
}
