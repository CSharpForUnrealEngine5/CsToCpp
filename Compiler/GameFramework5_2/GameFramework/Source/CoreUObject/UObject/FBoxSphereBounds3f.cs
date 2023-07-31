#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A bounding box and bounding sphere with the same origin.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBoxSphereBounds3f {
	public FVector3f Origin;
	public FVector3f BoxExtent;
	public float SphereRadius;
}
