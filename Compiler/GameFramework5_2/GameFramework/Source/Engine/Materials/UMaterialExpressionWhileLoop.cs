#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionWhileLoop.h")]
public partial class UMaterialExpressionWhileLoop : UMaterialExpression {
// MaterialExpressionWhileLoop
	public FExpressionExecOutput LoopBody;
	public FExpressionExecOutput Completed;
	public FExpressionInput Condition;
}
