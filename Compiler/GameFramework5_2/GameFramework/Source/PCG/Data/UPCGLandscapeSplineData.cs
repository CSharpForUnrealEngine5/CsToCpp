namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGLandscapeSplineData.h")]
public partial class UPCGLandscapeSplineData : UPCGPolyLineData {
	public static UClass StaticClass() {return default;}
	///<summary>Spline</summary>
	public TWeakObjectPtr<ULandscapeSplinesComponent> Spline;
}
