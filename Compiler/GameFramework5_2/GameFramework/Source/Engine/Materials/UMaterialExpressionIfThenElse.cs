#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionIfThenElse.h")]
public partial class UMaterialExpressionIfThenElse : UMaterialExpression {
// MaterialExpressionIfThenElse
	public FExpressionExecOutput Then;
	public FExpressionExecOutput Else;
	public FExpressionInput Condition;
}
