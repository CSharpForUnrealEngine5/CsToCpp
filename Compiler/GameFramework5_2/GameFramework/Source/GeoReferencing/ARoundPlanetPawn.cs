#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This pawn can be used to easily move around the globe while maintaining a</summary>
[CppInclude("RoundPlanetPawn.h")]
public partial class ARoundPlanetPawn : ADefaultPawn {
	public static UClass StaticClass() {return default;}
	///<summary>This curve dictates what percentage of the max altitude the pawn should take at a given time on the curve.</summary>
	public UCurveFloat AltitudeProfileCurve;
	///<summary>This curve is used to pick up a reference the maximum altitude when flying to a location.</summary>
	public UCurveFloat MaximumAltitudeCurve;
	///<summary>In case MaximumAltitudeCurve is not defined, the AltitudeProfileCurve will use this Maximum altitude value for the flight, whatever the travel distance.</summary>
	public float MaximumAltitudeValue;
	///<summary>This curve is used to ease in an out the Fly to Location speed.</summary>
	public UCurveFloat ProgressCurve;
	///<summary>Fly to Location duration (in seconds)</summary>
	public float FlyDuration;
	///<summary>The granularity in degrees with which keypoints should be generated for the Fly to Location interpolation.</summary>
	public float GranularityDegrees;
	///<summary>The minimum linear steps for the FlyTolocation motion.</summary>
	public int MinimumStepCount;
	///<summary>Make sure we don&#39;t get crazy in case of large flights with small granularity</summary>
	public int MaximumStepCount;
	///<summary>if True, the motion Forward/Right motion of the pawn are relative to Planet tangent,</summary>
	public bool OrbitalMotion;
	///<summary>The Reference maximum speed for the pawn, before being altered by any Scalar modifier or by altitude curve</summary>
	public float BaseSpeedKmh;
	///<summary>Scalar modifier for the base speed</summary>
	public float SpeedScalar;
	///<summary>Multiplier/Divider for increasing/decreasing the speed scalar</summary>
	public float SpeedScalarIncrement;
	///<summary>When being very high and moving around the planet, we have to dynamically increase the speed based on Height above terrain to accelerate movement</summary>
	public UCurveFloat SpeedByHATModifierCurve;
	///<summary>Height Above Terrain. The distance between the ground and the pawn</summary>
	public float HAT;
	///<summary>The distance between the geographic ellipsoid surface and the pawn</summary>
	public float Altitude;
	///<summary>Begin a smooth camera flight to the given ECEF destination such that the camera ends at the specified yaw and pitch.</summary>
	public  void FlyToLocationECEF(FVector ECEFDestination,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	///<summary>Begin a smooth camera flight to the given Latitude/Longitude destination such that the camera ends at the specified yaw and pitch.</summary>
	public  void FlyToLocationGeographic(FGeographicCoordinates GeographicDestination,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	///<summary>Begin a smooth camera flight to the given Latitude/Longitude destination such that the camera ends at the specified yaw and pitch.</summary>
	public  void FlyToLocationLatitudeLongitudeAltitude(double InLatitude,double InLongitude,double InAltitude,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	///<summary>Stop the current Fly To Location motion</summary>
	public  void InterruptFlyToLocation() {}
	///<summary>Reset the Speed Scalar to its default value - Middle-mouse button click equivalent</summary>
	public  void ResetSpeedScalar() {}
	///<summary>Increase the Speed Scalar - MouseWheel Up equivalent</summary>
	public  void IncreaseSpeedScalar() {}
	///<summary>Decrease the Speed Scalar - MouseWheel Down equivalent</summary>
	public  void DecreaseSpeedScalar() {}
	///<summary>GeoReferencingSystem</summary>
	public AGeoReferencingSystem GeoReferencingSystem;
}
