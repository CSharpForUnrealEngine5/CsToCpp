#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RoundPlanetPawn.h")]
///<summary>This pawn can be used to easily move around the globe while maintaining a</summary>
public partial class ARoundPlanetPawn : ADefaultPawn {
// RoundPlanetPawn
	public UCurveFloat AltitudeProfileCurve;
	public UCurveFloat MaximumAltitudeCurve;
	public float MaximumAltitudeValue;
	public UCurveFloat ProgressCurve;
	public float FlyDuration;
	public float GranularityDegrees;
	public int MinimumStepCount;
	public int MaximumStepCount;
	public bool OrbitalMotion;
	public float BaseSpeedKmh;
	public float SpeedScalar;
	public float SpeedScalarIncrement;
	public UCurveFloat SpeedByHATModifierCurve;
	public float HAT;
	public float Altitude;
	public void FlyToLocationECEF(FVector ECEFDestination,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	public void FlyToLocationGeographic(FGeographicCoordinates GeographicDestination,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	public void FlyToLocationLatitudeLongitudeAltitude(double InLatitude,double InLongitude,double InAltitude,double YawAtDestination,double PitchAtDestination,bool CanInterruptByMoving) {}
	public void InterruptFlyToLocation() {}
	public void ResetSpeedScalar() {}
	public void IncreaseSpeedScalar() {}
	public void DecreaseSpeedScalar() {}
	public AGeoReferencingSystem GeoReferencingSystem;
}
