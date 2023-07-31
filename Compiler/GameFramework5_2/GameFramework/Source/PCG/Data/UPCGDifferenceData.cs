#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGDifferenceData.h")]
public partial class UPCGDifferenceData : UPCGSpatialDataWithPointCache {
	///<summary>Initialize</summary>
	public  void Initialize(UPCGSpatialData InData) {}
	///<summary>AddDifference</summary>
	public  void AddDifference(UPCGSpatialData InDifference) {}
	///<summary>SetDensityFunction</summary>
	public  void SetDensityFunction(EPCGDifferenceDensityFunction InDensityFunction) {}
	///<summary>bDiffMetadata</summary>
	public bool bDiffMetadata;
	///<summary>Source</summary>
	public UPCGSpatialData Source;
	///<summary>Difference</summary>
	public UPCGSpatialData Difference;
	///<summary>DifferencesUnion</summary>
	public UPCGUnionData DifferencesUnion;
	///<summary>DensityFunction</summary>
	public EPCGDifferenceDensityFunction DensityFunction;
}
