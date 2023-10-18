namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionWhileLoop.h")]
public partial class UMaterialExpressionWhileLoop : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>LoopBody</summary>
	public FExpressionExecOutput LoopBody;
	///<summary>Completed</summary>
	public FExpressionExecOutput Completed;
	///<summary>Condition</summary>
	public FExpressionInput Condition;
}
