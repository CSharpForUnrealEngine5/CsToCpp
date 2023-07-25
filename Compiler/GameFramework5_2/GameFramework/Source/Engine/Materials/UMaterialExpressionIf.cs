#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionIf.h")]
public partial class UMaterialExpressionIf : UMaterialExpression {
// MaterialExpressionIf
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput AGreaterThanB;
	public FExpressionInput AEqualsB;
	public FExpressionInput ALessThanB;
	public float EqualsThreshold;
	public float ConstB;
	public float ConstAEqualsB_DEPRECATED;
}
