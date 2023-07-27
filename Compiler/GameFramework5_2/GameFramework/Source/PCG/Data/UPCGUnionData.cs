#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGUnionData.h")]
public partial class UPCGUnionData : UPCGSpatialDataWithPointCache {
// PCGUnionData
	public  void Initialize(UPCGSpatialData InA,UPCGSpatialData InB) {}
	public  void AddData(UPCGSpatialData InData) {}
	public TArray<UPCGSpatialData> Data;
	public UPCGSpatialData FirstNonTrivialTransformData;
	public EPCGUnionType UnionType;
	public EPCGUnionDensityFunction DensityFunction;
	public FBox CachedBounds;
	public FBox CachedStrictBounds;
	public int CachedDimension;
}
