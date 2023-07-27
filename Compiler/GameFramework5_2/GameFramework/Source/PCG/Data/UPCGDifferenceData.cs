#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGDifferenceData.h")]
public partial class UPCGDifferenceData : UPCGSpatialDataWithPointCache {
// PCGDifferenceData
	public  void Initialize(UPCGSpatialData InData) {}
	public  void AddDifference(UPCGSpatialData InDifference) {}
	public  void SetDensityFunction(EPCGDifferenceDensityFunction InDensityFunction) {}
	public bool bDiffMetadata;
	public UPCGSpatialData Source;
	public UPCGSpatialData Difference;
	public UPCGUnionData DifferencesUnion;
	public EPCGDifferenceDensityFunction DensityFunction;
}
