#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPoint.h")]
public partial struct FPCGPoint {
	public FTransform Transform;
	public float Density;
	public FVector BoundsMin;
	public FVector BoundsMax;
	public FVector4 Color;
	public float Steepness;
	public int Seed;
	public long MetadataEntry;
}
