#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
public partial struct FMaterialExpressionCollection {
// MaterialExpressionCollection
	public TArray<UMaterialExpression> Expressions;
	public TArray<UMaterialExpressionComment> EditorComments;
	public UMaterialExpressionExecBegin ExpressionExecBegin;
	public UMaterialExpressionExecEnd ExpressionExecEnd;
}
