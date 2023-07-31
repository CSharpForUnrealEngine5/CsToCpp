#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRotateAboutAxis.h")]
public partial class UMaterialExpressionRotateAboutAxis : UMaterialExpression {
	///<summary>NormalizedRotationAxis</summary>
	public FExpressionInput NormalizedRotationAxis;
	///<summary>RotationAngle</summary>
	public FExpressionInput RotationAngle;
	///<summary>PivotPoint</summary>
	public FExpressionInput PivotPoint;
	///<summary>Position</summary>
	public FExpressionInput Position;
	///<summary>Period</summary>
	public float Period;
}
