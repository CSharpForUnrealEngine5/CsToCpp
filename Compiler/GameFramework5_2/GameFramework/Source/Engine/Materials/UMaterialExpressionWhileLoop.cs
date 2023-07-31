#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionWhileLoop.h")]
public partial class UMaterialExpressionWhileLoop : UMaterialExpression {
	///<summary>LoopBody</summary>
	public FExpressionExecOutput LoopBody;
	///<summary>Completed</summary>
	public FExpressionExecOutput Completed;
	///<summary>Condition</summary>
	public FExpressionInput Condition;
}
