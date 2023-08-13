namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store spline data during RerunConstructionScripts</summary>
[CppInclude("Components/SplineComponent.h")]
public partial struct FSplineInstanceData {
	public bool bSplineHasBeenEdited;
	public FSplineCurves SplineCurves;
	public FSplineCurves SplineCurvesPreUCS;
}
