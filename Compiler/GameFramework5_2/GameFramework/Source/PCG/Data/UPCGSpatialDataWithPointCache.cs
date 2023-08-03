#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSpatialData.h")]
public partial class UPCGSpatialDataWithPointCache : UPCGSpatialData {
	public static UClass StaticClass() {return default;}
	///<summary>CachedPointData</summary>
	public UPCGPointData CachedPointData;
	///<summary>CachedBoundedPointDataBoxes</summary>
	public TArray<FBox> CachedBoundedPointDataBoxes;
	///<summary>CachedBoundedPointData</summary>
	public TArray<UPCGPointData> CachedBoundedPointData;
}
