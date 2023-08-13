namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Draws the given spline in the viewport</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_DrawControlRigSpline {
	public FControlRigSpline Spline;
	public FLinearColor Color;
	public float Thickness;
	public int Detail;
}
