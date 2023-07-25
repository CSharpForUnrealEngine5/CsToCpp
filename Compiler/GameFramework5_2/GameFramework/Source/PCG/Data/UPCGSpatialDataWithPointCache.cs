#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSpatialData.h")]
public partial class UPCGSpatialDataWithPointCache : UPCGSpatialData {
// PCGSpatialDataWithPointCache
	public UPCGPointData CachedPointData;
	public TArray<FBox> CachedBoundedPointDataBoxes;
	public TArray<UPCGPointData> CachedBoundedPointData;
}
