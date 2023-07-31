#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionForLoop.h")]
public partial class UMaterialExpressionForLoop : UMaterialExpression {
	///<summary>LoopBody</summary>
	public FExpressionExecOutput LoopBody;
	///<summary>Completed</summary>
	public FExpressionExecOutput Completed;
	///<summary>StartIndex</summary>
	public FExpressionInput StartIndex;
	///<summary>EndIndex</summary>
	public FExpressionInput EndIndex;
	///<summary>IndexStep</summary>
	public FExpressionInput IndexStep;
}
