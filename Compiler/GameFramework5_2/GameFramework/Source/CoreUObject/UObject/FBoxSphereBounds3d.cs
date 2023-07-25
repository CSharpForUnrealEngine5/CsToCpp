#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A bounding box and bounding sphere with the same origin.</summary>
public partial struct FBoxSphereBounds3d {
// BoxSphereBounds3d
	public FVector3d Origin;
	public FVector3d BoxExtent;
	public double SphereRadius;
}
