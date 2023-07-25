#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
///<summary>Used to store spline data during RerunConstructionScripts</summary>
public partial struct FSplineInstanceData {
// SplineInstanceData
	public bool bSplineHasBeenEdited;
	public FSplineCurves SplineCurves;
	public FSplineCurves SplineCurvesPreUCS;
}
