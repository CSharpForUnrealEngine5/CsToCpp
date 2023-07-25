#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDistanceFieldApproxAO.h")]
public partial class UMaterialExpressionDistanceFieldApproxAO : UMaterialExpression {
// MaterialExpressionDistanceFieldApproxAO
	public FExpressionInput Position;
	public FExpressionInput Normal;
	public FExpressionInput BaseDistance;
	public float BaseDistanceDefault;
	public FExpressionInput Radius;
	public float RadiusDefault;
	public uint NumSteps;
	public float StepScaleDefault;
}
