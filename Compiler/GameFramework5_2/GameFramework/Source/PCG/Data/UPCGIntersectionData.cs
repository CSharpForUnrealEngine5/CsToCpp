#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic intersection class that delays operations as long as possible.</summary>
[CppInclude("Data/PCGIntersectionData.h")]
public partial class UPCGIntersectionData : UPCGSpatialDataWithPointCache {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize</summary>
	public  void Initialize(UPCGSpatialData InA,UPCGSpatialData InB) {}
	///<summary>DensityFunction</summary>
	public EPCGIntersectionDensityFunction DensityFunction;
	///<summary>A</summary>
	public UPCGSpatialData A;
	///<summary>B</summary>
	public UPCGSpatialData B;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
}
