namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores specific camera settings to be retrieved at a later time</summary>
[CppInclude("VirtualCameraSaveGame.h")]
public partial struct FVirtualCameraSettings {
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
