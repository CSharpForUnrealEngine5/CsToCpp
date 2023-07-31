#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGUnionData.h")]
public partial class UPCGUnionData : UPCGSpatialDataWithPointCache {
	///<summary>Initialize</summary>
	public  void Initialize(UPCGSpatialData InA,UPCGSpatialData InB) {}
	///<summary>AddData</summary>
	public  void AddData(UPCGSpatialData InData) {}
	///<summary>Data</summary>
	public TArray<UPCGSpatialData> Data;
	///<summary>FirstNonTrivialTransformData</summary>
	public UPCGSpatialData FirstNonTrivialTransformData;
	///<summary>UnionType</summary>
	public EPCGUnionType UnionType;
	///<summary>DensityFunction</summary>
	public EPCGUnionDensityFunction DensityFunction;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
	///<summary>CachedDimension</summary>
	public int CachedDimension;
}
