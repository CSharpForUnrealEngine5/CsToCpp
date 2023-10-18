namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Positional location and rotation parameters for use with nDisplay stage actors.</summary>
[CppInclude("StageActor/DisplayClusterPositionalParams.h")]
public partial struct FDisplayClusterPositionalParams {
	public double DistanceFromCenter;
	public double Longitude;
	public double Latitude;
	public double Spin;
	public double Pitch;
	public double Yaw;
	public double RadialOffset;
	public FVector2D Scale;
}
