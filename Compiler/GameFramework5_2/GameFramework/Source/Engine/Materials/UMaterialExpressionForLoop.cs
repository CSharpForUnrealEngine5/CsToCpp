#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionForLoop.h")]
public partial class UMaterialExpressionForLoop : UMaterialExpression {
// MaterialExpressionForLoop
	public FExpressionExecOutput LoopBody;
	public FExpressionExecOutput Completed;
	public FExpressionInput StartIndex;
	public FExpressionInput EndIndex;
	public FExpressionInput IndexStep;
}
