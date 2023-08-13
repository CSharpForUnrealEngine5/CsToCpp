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
