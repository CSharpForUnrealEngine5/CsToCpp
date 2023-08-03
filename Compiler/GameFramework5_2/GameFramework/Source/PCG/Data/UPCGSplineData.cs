#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSplineData.h")]
public partial class UPCGSplineData : UPCGPolyLineData {
	public static UClass StaticClass() {return default;}
	///<summary>Minimal data needed to replicate the behavior from USplineComponent</summary>
	public FPCGSplineStruct SplineStruct;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
}
