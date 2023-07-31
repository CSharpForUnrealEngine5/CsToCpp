#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store spline data during RerunConstructionScripts</summary>
[CppInclude("Components/SplineComponent.h")]
public partial struct FSplineInstanceData {
	public bool bSplineHasBeenEdited;
	public FSplineCurves SplineCurves;
	public FSplineCurves SplineCurvesPreUCS;
}
