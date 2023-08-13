namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple struct to hold spline point data</summary>
[CppInclude("CineSplinePointData.h")]
public partial struct FCineSplinePointData {
	public FVector Location;
	public FRotator Rotation;
	public float FocalLength;
	public float Aperture;
	public float FocusDistance;
}
