#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic projection class (A projected onto B) that intercepts spatial queries</summary>
[CppInclude("Data/PCGProjectionData.h")]
public partial class UPCGProjectionData : UPCGSpatialDataWithPointCache {
	public static UClass StaticClass() {return default;}
	///<summary>Source</summary>
	public UPCGSpatialData Source;
	///<summary>Target</summary>
	public UPCGSpatialData Target;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
	///<summary>ProjectionParams</summary>
	public FPCGProjectionParams ProjectionParams;
}
