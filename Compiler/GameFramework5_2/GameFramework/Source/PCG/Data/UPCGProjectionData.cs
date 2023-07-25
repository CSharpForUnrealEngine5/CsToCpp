#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGProjectionData.h")]
///<summary>Generic projection class (A projected onto B) that intercepts spatial queries</summary>
public partial class UPCGProjectionData : UPCGSpatialDataWithPointCache {
// PCGProjectionData
	public UPCGSpatialData Source;
	public UPCGSpatialData Target;
	public FBox CachedBounds;
	public FBox CachedStrictBounds;
	public FPCGProjectionParams ProjectionParams;
}
