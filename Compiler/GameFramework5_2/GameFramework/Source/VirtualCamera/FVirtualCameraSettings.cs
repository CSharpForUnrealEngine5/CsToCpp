#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
///<summary>Stores specific camera settings to be retrieved at a later time</summary>
public partial struct FVirtualCameraSettings {
// VirtualCameraSettings
	public float FocalLength;
	public float Aperture;
	public string FilmbackName;
	public float FilmbackWidth;
	public float FilmbackHeight;
	public float MatteOpacity;
	public TMap<EVirtualCameraAxis,FVirtualCameraAxisSettings> AxisSettings;
	public bool bAllowFocusVisualization;
	public FColor DebugFocusPlaneColor;
	public EUnit DesiredDistanceUnits;
}
