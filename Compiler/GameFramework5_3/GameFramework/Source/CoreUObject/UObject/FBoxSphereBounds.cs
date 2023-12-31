namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A bounding box and bounding sphere with the same origin.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBoxSphereBounds {
	public FVector Origin;
	public FVector BoxExtent;
	public double SphereRadius;
}
