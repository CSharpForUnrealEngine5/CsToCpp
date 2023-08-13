namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
public partial struct FMaterialExpressionCollection {
	public TArray<UMaterialExpression> Expressions;
	public TArray<UMaterialExpressionComment> EditorComments;
	public UMaterialExpressionExecBegin ExpressionExecBegin;
	public UMaterialExpressionExecEnd ExpressionExecEnd;
}
