#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineGeneratorPanel.h")]
public partial class UEllipseSplineGenerator : USplineGeneratorBase {
	///<summary>NumberOfPoints</summary>
	public int NumberOfPoints;
	///<summary>Length</summary>
	public float Length;
	///<summary>Width</summary>
	public float Width;
	///<summary>If enabled, will reverse the direction of the arc</summary>
	public bool bReverseDir;
	///<summary>If enabled, will start the shape tangent to the current path</summary>
	public bool bKeepFirstKeyTangent;
	///<summary>If enabled, will switch the shape&#39;s center to the right of the curve</summary>
	public bool bBranchRight;
}
