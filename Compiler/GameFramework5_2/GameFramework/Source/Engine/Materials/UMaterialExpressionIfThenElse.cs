namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionIfThenElse.h")]
public partial class UMaterialExpressionIfThenElse : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Then</summary>
	public FExpressionExecOutput Then;
	///<summary>Else</summary>
	public FExpressionExecOutput Else;
	///<summary>Condition</summary>
	public FExpressionInput Condition;
}
