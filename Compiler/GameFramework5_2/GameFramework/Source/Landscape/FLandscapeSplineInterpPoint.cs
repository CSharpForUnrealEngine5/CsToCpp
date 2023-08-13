namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineSegment.h")]
public partial struct FLandscapeSplineInterpPoint {
	public FVector Center;
	public FVector Left;
	public FVector Right;
	public FVector FalloffLeft;
	public FVector FalloffRight;
	public FVector LayerLeft;
	public FVector LayerRight;
	public FVector LayerFalloffLeft;
	public FVector LayerFalloffRight;
	public float StartEndFalloff;
}
