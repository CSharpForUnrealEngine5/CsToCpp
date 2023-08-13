namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The projection of a spline onto a surface.</summary>
[CppInclude("Data/PCGSplineData.h")]
public partial class UPCGSplineProjectionData : UPCGProjectionData {
	public static UClass StaticClass() {return default;}
	///<summary>ProjectedPosition</summary>
	public FInterpCurveVector2D ProjectedPosition;
}
