#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGIntersectionData.h")]
///<summary>Generic intersection class that delays operations as long as possible.</summary>
public partial class UPCGIntersectionData : UPCGSpatialDataWithPointCache {
// PCGIntersectionData
	public void Initialize(UObject InA,UObject InB) {}
	public EPCGIntersectionDensityFunction DensityFunction;
	public UPCGSpatialData A;
	public UPCGSpatialData B;
	public FBox CachedBounds;
	public FBox CachedStrictBounds;
}
