#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SunPosition.h")]
public partial struct FSunPositionData {
	public float Elevation;
	public float CorrectedElevation;
	public float Azimuth;
	public FTimespan SunriseTime;
	public FTimespan SunsetTime;
	public FTimespan SolarNoon;
}
